using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class DistrictService : IDistrictService
    {
        private readonly IDistrictRepository repository;

        public DistrictService(IDistrictRepository repository)
        {
            this.repository = repository;
        }

        public async Task<District> AddDistrictAsync(District objDistrict)
        {
            return await repository.AddAsync(objDistrict);
        }

        public async Task UpdateDistrictAsync(District objDistrict)
        {
            await repository.UpdateAsync(objDistrict);
        }

        public async Task<IEnumerable<District>> GetAllDistrictAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<District> GetDistrictByIdAsync(District objDistrict)
        {
            return await repository.GetByIdAsync(objDistrict.Id);
        }
    }

}
