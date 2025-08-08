using Application.Services.Interfaces;
using Domain.DbModels.Common;
using Domain.Identity.DbModels.Security;
using Infrastructure.Identity.RepositoryBase;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations
{
    public class MenuService : IMenuService
    {
        private readonly IApplicationRepository<Country> _countryRepo;
        private readonly IIdentityRepository<Menu> _repository;

        public MenuService(
            IApplicationRepository<Country> countryRepo,
            IIdentityRepository<Menu> repository)
        {
            _countryRepo = countryRepo;
            _repository = repository;
        }

        public async Task<Menu> AddMenuAsync(Menu objMenu)
        {
            return await _repository.AddAsync(objMenu);
        }

        public async Task UpdateMenuAsync(Menu objMenu)
        {
            await _repository.UpdateAsync(objMenu);
        }

        public async Task<IEnumerable<Menu>> GetAllMenuAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Menu> GetMenuByIdAsync(Menu objMenu)
        {
            return await _repository.GetByIdAsync(objMenu.Id);
        }
    }

}
