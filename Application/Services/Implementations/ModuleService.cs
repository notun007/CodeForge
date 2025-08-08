using Application.Services.Interfaces;
using Domain.DbModels.Common;
using Domain.Identity.DbModels.Security;
using Infrastructure.Identity.RepositoryBase;
using Infrastructure.Persistence.RepositoryBase;

namespace Application.Services.Implementations
{
    public class ModuleService : IModuleService
    {
        private readonly IApplicationRepository<Country> _countryRepo;
        private readonly IIdentityRepository<Module> _repository;
        public ModuleService(
           IApplicationRepository<Country> countryRepo,
           IIdentityRepository<Module> repository)
        {
            _countryRepo = countryRepo;
            _repository = repository;
        }

        public async Task<Module> AddModuleAsync(Module objModule)
        {
            return await _repository.AddAsync(objModule);
        }

        public async Task UpdateModuleAsync(Module objModule)
        {
            await _repository.UpdateAsync(objModule);
        }

        public async Task<IEnumerable<Module>> GetAllModuleAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Module> GetModuleByIdAsync(Module objModule)
        {
            return await _repository.GetByIdAsync(objModule.Id);
        }
    }
}
