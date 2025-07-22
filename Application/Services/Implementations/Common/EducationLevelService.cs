using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class EducationLevelService : IEducationLevelService
    {
        private readonly IEducationLevelRepository repository;

        public EducationLevelService(IEducationLevelRepository repository)
        {
            this.repository = repository;
        }

        public async Task<EducationLevel> AddEducationLevelAsync(EducationLevel objEducationLevel)
        {
            return await repository.AddAsync(objEducationLevel);
        }

        public async Task UpdateEducationLevelAsync(EducationLevel objEducationLevel)
        {
            await repository.UpdateAsync(objEducationLevel);
        }

        public async Task<IEnumerable<EducationLevel>> GetAllEducationLevelAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<EducationLevel> GetEducationLevelByIdAsync(EducationLevel objEducationLevel)
        {
            return await repository.GetByIdAsync(objEducationLevel.Id);
        }
    }

}
