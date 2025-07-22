using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class ReligionService : IReligionService
    {
        private readonly IReligionRepository repository;

        public ReligionService(IReligionRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Religion> AddReligionAsync(Religion objReligion)
        {
            return await repository.AddAsync(objReligion);
        }

        public async Task UpdateReligionAsync(Religion objReligion)
        {
            await repository.UpdateAsync(objReligion);
        }

        public async Task<IEnumerable<Religion>> GetAllReligionAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Religion> GetReligionByIdAsync(Religion objReligion)
        {
            return await repository.GetByIdAsync(objReligion.Id);
        }
    }

}
