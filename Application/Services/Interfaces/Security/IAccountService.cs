
using Domain.Identity.Common;
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
        Task<Response<UserIdentityDto>> RegisterUserAsync(RegisterUserDto registerUserDto);
        Task<Response<UserIdentityDto>> CookieSignInAsync(LoginUserDto loginUserDto);
        Task<Response<UserIdentityDto>> CheckPasswordAsync(LoginUserDtoForApi loginUserDto);
        Task CookieSignOutAsync();
    }
}
