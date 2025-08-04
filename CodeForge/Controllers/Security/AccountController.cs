using Application.Services.Interfaces.Security;
using Domain.Identity.Common;
using Domain.Identity.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CodeForge.Controllers.Security
{

    [Route("api/[controller]")]
    [ApiController]
    public class AccountController(IAccountService accountService) : ControllerBase
    {
        [HttpPost("authenticate")]
        public async Task<IActionResult> AuthenticateAsync(AuthenticationRequest request)
        {
            return Ok(await accountService.AuthenticateAsync(request, GenerateIPAddress()));
        }
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterRequest request)
        {
            var origin = Request.Headers["origin"];
            return Ok(await accountService.RegisterAsync(request, origin));
        }
        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmailAsync([FromQuery] string userId, [FromQuery] string code)
        {
            var origin = Request.Headers["origin"];
            return Ok(await accountService.ConfirmEmailAsync(userId, code));
        }
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordRequest model)
        {
            await accountService.ForgotPassword(model, Request.Headers["origin"]);
            return Ok();
        }
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPasswordRequest model)
        {

            return Ok(await accountService.ResetPassword(model));
        }
        private string GenerateIPAddress()
        {
            if (Request.Headers.ContainsKey("X-Forwarded-For"))
                return Request.Headers["X-Forwarded-For"];
            else
                return HttpContext.Connection.RemoteIpAddress.MapToIPv4().ToString();
        }
    }




    //[Route("api/[controller]")]
    //[ApiController]

    //public class AccountController : ControllerBase
    //{

    //    private readonly IAccountService _accountService;
    //    private readonly IConfiguration _configuration;

    //    public AccountController(IAccountService accountService, IConfiguration configuration)
    //    {
    //        _accountService = accountService;
    //        _configuration = configuration;
    //    }

    //    [HttpPost, Route("login")]
    //    [AllowAnonymous]
    //    public async Task<IActionResult> Login(LoginUserDtoForApi loginUserDto)
    //    {
    //        try
    //        {
    //            if (string.IsNullOrEmpty(loginUserDto.UserName) ||
    //            string.IsNullOrEmpty(loginUserDto.Password))
    //                return BadRequest("Username and/or Password not specified");

    //            var rs = await _accountService.CheckPasswordAsync(loginUserDto);

    //            if (rs.Succeeded)
    //            {
    //                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetValue<string>("Jwt:Key")));

    //                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
    //                var claims = new[] {
    //                    new Claim(ClaimTypes.Name, loginUserDto.UserName),
    //                    new Claim(ClaimTypes.NameIdentifier, rs.Data.Id),
    //                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
    //                };

    //                var jwtSecurityToken = new JwtSecurityToken(

    //                    issuer: _configuration.GetValue<string>("Jwt:Issuer"),
    //                    audience: _configuration.GetValue<string>("Jwt:Audience"),
    //                    claims: claims,
    //                    expires: DateTime.Now.AddMinutes(100),
    //                    signingCredentials: signinCredentials
    //                );

    //                return Ok(new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken));
    //            }
    //        }
    //        catch (Exception e)
    //        {
    //            //Log.Error(e, e.Message);
    //            return BadRequest
    //            ("An error occurred in generating the token");
    //        }
    //        return Unauthorized();
    //    }
    //}


}
