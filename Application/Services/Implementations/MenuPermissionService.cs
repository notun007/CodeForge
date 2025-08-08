using Application.Services.Interfaces;
using Domain.Identity.DbModels.Security;
using Domain.Identity.ViewModels.Security;
using Infrastructure.Identity.Interfaces.Security;
using Infrastructure.Identity.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class MenuPermissionService : IMenuPermissionService
    {
        //private readonly IIdentityRepository<MenuPermission> _repository;
        private readonly IMenuPermissionRepository _repository;

        public MenuPermissionService(IMenuPermissionRepository repository)
        {
            _repository = repository;
        }

        public async Task<MenuPermission> AddMenuPermissionAsync(MenuPermission obj)
        {
            return await _repository.AddAsync(obj);
        }

        public async Task UpdateMenuPermissionAsync(MenuPermission obj)
        {
            await _repository.UpdateAsync(obj);
        }

        public async Task<IEnumerable<MenuPermission>> GetAllMenuPermissionAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<MenuPermission> GetMenuPermissionByIdAsync(MenuPermission obj)
        {
            return await _repository.GetByIdAsync(obj.Id);
        }

        public async Task<List<ModuleViewModel>> GetModuleMenuByRole(string roleId)
        {
            return await _repository.GetModuleMenuByRole(roleId);
        }
    }

}
