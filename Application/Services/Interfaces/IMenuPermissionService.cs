using Domain.Identity.DbModels.Security;
using Domain.Identity.ViewModels.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IMenuPermissionService
    {
        Task<MenuPermission> AddMenuPermissionAsync(MenuPermission obj);
        Task UpdateMenuPermissionAsync(MenuPermission obj);
        Task<IEnumerable<MenuPermission>> GetAllMenuPermissionAsync();
        Task<MenuPermission> GetMenuPermissionByIdAsync(MenuPermission obj);
        Task<List<ModuleViewModel>> GetModuleMenuByRole(string roleId);
    }

}
