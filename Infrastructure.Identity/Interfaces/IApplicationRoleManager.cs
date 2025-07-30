using Domain.Identity.DbModels.Security;
using Domain.Identity.ViewModels.Security;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Interfaces
{
    public interface IApplicationRoleManager
    {
        Task<IList<Claim>> GetClaimsAsync(string roleName);
        Task<IList<Claim>> GetClaimsAsync(IList<string> roleNames);
        Task<ApplicationRole> GetRoleAsync(string roleName);
        Task<ApplicationRole> FindByIdAsync(string roleId);
        Task<IList<Claim>> GetClaimsAsync(ApplicationRole role);
        Task<IdentityResponse> RemoveClaimAsync(ApplicationRole role, Claim claim);
        Task<IdentityResponse> AddClaimAsync(ApplicationRole role, Claim claim);
        IQueryable<ApplicationRole> Roles();

        /// <summary>
        /// Add new role to database role table.
        /// </summary>
        /// <param name="applicationRole"></param>
        /// <returns>IdentityResponse object.</returns>
        Task<IdentityResponse> AddRoleAsync(ApplicationRole applicationRole);
    }
}
