﻿using Application.Exceptions;
using Application.Services.Interfaces.Security;
using AutoMapper;
using AutoMapper.Internal;

//using Azure;
using Domain.Identity.Common;
using Domain.Identity.DbModels.Security;
using Domain.Identity.Enum;
using Domain.Identity.Request;
using Domain.Identity.Response;
using Domain.Identity.Settings;
using Infrastructure.Identity.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Security
{
    //New:30072025
    public class AccountService(
    UserManager<ApplicationUser> userManager,
       
    IOptions<JWTSettings> jwtSettings,
    SignInManager<ApplicationUser> signInManager,
    IEmailService emailService,
    IFeatureManager featureManager)
    : IAccountService
    {
        private readonly JWTSettings _jwtSettings = jwtSettings.Value;

        public async Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress)
        {
            var user = await userManager.FindByEmailAsync(request.Email);
            if (user == null)
            {
                throw new ApiException($"No Accounts Registered with {request.Email}.");
            }
            var result = await signInManager.PasswordSignInAsync(user.UserName, request.Password, false, lockoutOnFailure: false);
            if (!result.Succeeded)
            {
                throw new ApiException($"Invalid Credentials for '{request.Email}'.");
            }
            if (!user.EmailConfirmed)
            {
                throw new ApiException($"Account Not Confirmed for '{request.Email}'.");
            }
            JwtSecurityToken jwtSecurityToken = await GenerateJWToken(user);
            AuthenticationResponse response = new AuthenticationResponse();
            response.Id = user.Id;
            response.JWToken = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            response.Email = user.Email;
            response.UserName = user.UserName;
            var rolesList = await userManager.GetRolesAsync(user).ConfigureAwait(false);
            response.Roles = rolesList.ToList();
            response.IsVerified = user.EmailConfirmed;
            var refreshToken = GenerateRefreshToken(ipAddress);
            response.RefreshToken = refreshToken.Token;

           return new Response<AuthenticationResponse>(response, $"Authenticated {user.UserName}");

        }

        public async Task<Response<string>> RegisterAsync(RegisterRequest request, string origin)
        {
            var userWithSameUserName = await userManager.FindByNameAsync(request.UserName);
            if (userWithSameUserName != null)
            {
                throw new ApiException($"Username '{request.UserName}' is already taken.");
            }
            var user = new ApplicationUser
            {
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName
            };
            var userWithSameEmail = await userManager.FindByEmailAsync(request.Email);
            if (userWithSameEmail == null)
            {
                var result = await userManager.CreateAsync(user, request.Password);
                if (result.Succeeded)
                {
                    string role = Roles.Basic.ToString();

                    await userManager.AddToRoleAsync(user, Roles.Basic.ToString());
                    var verificationUri = await SendVerificationEmail(user, origin);

                    if (await featureManager.IsEnabledAsync(nameof(FeatureManagement.EnableEmailService)))
                    {
                        await emailService.SendEmailAsync(new MailRequest() { From = "amit.naik8103@gmail.com", ToEmail = user.Email, Body = $"Please confirm your account by visiting this URL {verificationUri}", Subject = "Confirm Registration" });
                    }
                    return new Response<string>(user.Id, message: $"User Registered. Please confirm your account by visiting this URL {verificationUri}");
                }
                else
                {
                    throw new ApiException($"{result.Errors.ToList()[0].Description}");
                }
            }
            else
            {
                throw new ApiException($"Email {request.Email} is already registered.");
            }
        }

        private async Task<JwtSecurityToken> GenerateJWToken(ApplicationUser user)
        {
            var userClaims = await userManager.GetClaimsAsync(user);
            var roles = await userManager.GetRolesAsync(user);

            var roleClaims = roles.Select(t => new Claim("roles", t)).ToList();

            string ipAddress = IpHelper.GetIpAddress();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id),
                new Claim("ip", ipAddress)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Key));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _jwtSettings.Issuer,
                audience: _jwtSettings.Audience,
            claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_jwtSettings.DurationInMinutes),
                signingCredentials: signingCredentials);
            return jwtSecurityToken;
        }

        private string RandomTokenString()
        {
            using var rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            var randomBytes = new byte[40];
            rngCryptoServiceProvider.GetBytes(randomBytes);
            // convert random bytes to hex string
            return BitConverter.ToString(randomBytes).Replace("-", "");
        }

        private async Task<string> SendVerificationEmail(ApplicationUser user, string origin)
        {
            var code = await userManager.GenerateEmailConfirmationTokenAsync(user);
            code = WebEncoders.Base64UrlEncode(Encoding.UTF8.GetBytes(code));
            var route = "api/account/confirm-email/";
            var endpointUri = new Uri(string.Concat($"{origin}/", route));
            var verificationUri = QueryHelpers.AddQueryString(endpointUri.ToString(), "userId", user.Id);
            verificationUri = QueryHelpers.AddQueryString(verificationUri, "code", code);
            //Email Service Call Here
            return verificationUri;
        }

        public async Task<Response<string>> ConfirmEmailAsync(string userId, string code)
        {
            var user = await userManager.FindByIdAsync(userId);
            code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));
            var result = await userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
            {
                return new Response<string>(user.Id, message: $"Account Confirmed for {user.Email}. You can now use the /api/Account/authenticate endpoint.");
            }
            else
            {
                throw new ApiException($"An error occured while confirming {user.Email}.");
            }
        }

        private RefreshToken GenerateRefreshToken(string ipAddress)
        {
            return new RefreshToken
            {
                Token = RandomTokenString(),
                Expires = DateTime.UtcNow.AddDays(7),
                Created = DateTime.UtcNow,
                CreatedByIp = ipAddress
            };
        }

        public async Task ForgotPassword(ForgotPasswordRequest model, string origin)
        {
            var account = await userManager.FindByEmailAsync(model.Email);

            // always return ok response to prevent email enumeration
            if (account == null) return;

            var code = await userManager.GeneratePasswordResetTokenAsync(account);
            var emailRequest = new MailRequest()
            {
                Body = $"You reset token is - {code}",
                ToEmail = model.Email,
                Subject = "Reset Password",
            };
            await emailService.SendEmailAsync(emailRequest);
        }

        public async Task<Response<string>> ResetPassword(ResetPasswordRequest model)
        {
            var account = await userManager.FindByEmailAsync(model.Email);
            if (account == null) throw new ApiException($"No Accounts Registered with {model.Email}.");
            var result = await userManager.ResetPasswordAsync(account, model.Token, model.Password);
            if (result.Succeeded)
            {
                return new Response<string>(model.Email, message: $"Password Resetted.");
            }
            else
            {
                throw new ApiException($"Error occured while reseting the password.");
            }
        }
    }

    //Old: 30072025
    //public class AccountService : IAccountService
    //{
    //    private readonly IApplicationUserManager _userManager;
    //    private readonly IApplicationSignInManager _signInManager;
    //    private readonly IApplicationRoleManager _roleManager;
    //    private readonly IMapper _mapper;

    //    public AccountService(IApplicationUserManager userManager,
    //                            IApplicationSignInManager signInManager,
    //                            IApplicationRoleManager roleManager,
    //                            IMapper mapper)
    //    {
    //        _userManager = userManager;
    //        _signInManager = signInManager;
    //        _roleManager = roleManager;
    //        _mapper = mapper;
    //    }
    //    public async Task<Response<UserIdentityDto>> RegisterUserAsync(RegisterUserDto registerUserDto)
    //    {
    //        var user = _mapper.Map<ApplicationUser>(registerUserDto);
    //        var rs = await _userManager.RegisterUserAsync(user);
    //        return rs.Succeeded
    //            ? Response<UserIdentityDto>.Success(new UserIdentityDto { Id = user.Id }, rs.ToString())
    //            : Response<UserIdentityDto>.Fail(rs.ToString());
    //    }

    //    public async Task<Response<UserIdentityDto>> CookieSignInAsync(LoginUserDto loginUserDto)
    //    {
    //        var user = await _userManager.GetUserByNameAsync(loginUserDto.UserName);
    //        if (user == null) return Response<UserIdentityDto>.Fail("UserName does not exists");
    //        var rs = await _signInManager.PasswordSignInAsync(user, loginUserDto.Password,
    //            loginUserDto.RememberMe, false);
    //        return rs.Succeeded
    //            ? Response<UserIdentityDto>.Success(new UserIdentityDto { Id = user.Id }, rs.ToString())
    //            : Response<UserIdentityDto>.Fail(rs.ToString());
    //    }

    //    public async Task CookieSignOutAsync()
    //    {
    //        await _signInManager.SignOutAsync();
    //    }

    //    public async Task<Response<UserIdentityDto>> CheckPasswordAsync(LoginUserDtoForApi loginUserDto)
    //    {
    //        var user = await _userManager.GetUserByNameAsync(loginUserDto.UserName);
    //        if (user == null) return Response<UserIdentityDto>.Fail("UserName does not exists");

    //        var rs = await _userManager.CheckPasswordAsync(user, loginUserDto.Password);
    //        return rs.Succeeded
    //            ? Response<UserIdentityDto>.Success(new UserIdentityDto { Id = user.Id }, rs.ToString())
    //            : Response<UserIdentityDto>.Fail(rs.ToString());
    //    }
    //}

}
