
using Domain.Identity.Common;
using Domain.Identity.Request;
using Domain.Identity.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces.Security
{
    public interface IAccountService
    {
        Task<Response<AuthenticationResponse>> AuthenticateAsync(AuthenticationRequest request, string ipAddress);
        Task<Response<string>> RegisterAsync(RegisterRequest request, string origin);
        Task<Response<string>> ConfirmEmailAsync(string userId, string code);
        Task ForgotPassword(ForgotPasswordRequest model, string origin);
        Task<Response<string>> ResetPassword(ResetPasswordRequest model);

        //Task<Response<UserIdentityDto>> RegisterUserAsync(RegisterUserDto registerUserDto);
        //Task<Response<UserIdentityDto>> CookieSignInAsync(LoginUserDto loginUserDto);
        //Task<Response<UserIdentityDto>> CheckPasswordAsync(LoginUserDtoForApi loginUserDto);
        //Task CookieSignOutAsync();
    }
}
