using Application.Services.Interfaces;
using Domain.Identity.DbModels.Security;
using Infrastructure.Identity.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class ApplicationRoleService : IApplicationRoleService
    {
        private readonly IIdentityRepository<ApplicationRole> _repository;

        public ApplicationRoleService(IIdentityRepository<ApplicationRole> repository)
        {
            _repository = repository;
        }

        public async Task<ApplicationRole> AddRoleAsync(ApplicationRole role)
        {
            return await _repository.AddAsync(role);
        }

        public async Task UpdateRoleAsync(ApplicationRole role)
        {
            await _repository.UpdateAsync(role);
        }

        public async Task<IEnumerable<ApplicationRole>> GetAllRolesAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<ApplicationRole> GetRoleByIdAsync(string roleId)
        {
            return await _repository.GetByIdAsync(roleId);
        }
    }

}
