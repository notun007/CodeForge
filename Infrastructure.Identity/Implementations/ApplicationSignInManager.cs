using System.Threading.Tasks;
using Domain.Identity.DbModels.Security;
using Domain.Identity.ViewModels.Security;
using Infrastructure.Identity.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity.Implementations
{
    public class ApplicationSignInManager : IApplicationSignInManager
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public ApplicationSignInManager(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public async Task<IdentityResponse> PasswordSignInAsync(ApplicationUser user, string password, bool isPersistent, bool lockoutOnFailure)
        {
            var rs = await _signInManager.PasswordSignInAsync(user, password, isPersistent, lockoutOnFailure);
            return rs.Succeeded ? IdentityResponse.Success(rs.ToString()) : IdentityResponse.Fail(rs.ToString());
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
