using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class OccupationService : IOccupationService
    {
        private readonly IOccupationRepository repository;

        public OccupationService(IOccupationRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Occupation> AddOccupationAsync(Occupation objOccupation)
        {
            return await repository.AddAsync(objOccupation);
        }

        public async Task UpdateOccupationAsync(Occupation objOccupation)
        {
            await repository.UpdateAsync(objOccupation);
        }

        public async Task<IEnumerable<Occupation>> GetAllOccupationAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Occupation> GetOccupationByIdAsync(Occupation objOccupation)
        {
            return await repository.GetByIdAsync(objOccupation.Id);
        }
    }

}
