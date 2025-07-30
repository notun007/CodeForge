using Domain.Identity.DbModels.Security;
using Domain.Identity.ViewModels.Security;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Interfaces
{
    public interface IApplicationSignInManager
    {
        Task<IdentityResponse> PasswordSignInAsync(ApplicationUser user, string password, bool isPersistent,
            bool lockoutOnFailure);

        Task SignOutAsync();
    }
}
