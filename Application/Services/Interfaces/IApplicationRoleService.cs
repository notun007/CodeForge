using Domain.Identity.DbModels.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IApplicationRoleService
    {
        Task<ApplicationRole> AddRoleAsync(ApplicationRole role);
        Task UpdateRoleAsync(ApplicationRole role);
        Task<IEnumerable<ApplicationRole>> GetAllRolesAsync();
        Task<ApplicationRole> GetRoleByIdAsync(string roleId);
    }

}
