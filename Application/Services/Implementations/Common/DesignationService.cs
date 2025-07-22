using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{   
    public class DesignationService : IDesignationService
    {
        private readonly IDesignationRepository repository;

        public DesignationService(IDesignationRepository repository)
        {
            this.repository = repository;
        }

        public async Task<Designation> AddDesignationAsync(Designation objDesignation)
        {
            return await repository.AddAsync(objDesignation);
        }

        public async Task UpdateDesignationAsync(Designation objDesignation)
        {
            await repository.UpdateAsync(objDesignation);
        }

        public async Task<IEnumerable<Designation>> GetAllDesignationAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<Designation> GetDesignationByIdAsync(Designation objDesignation)
        {
            return await repository.GetByIdAsync(objDesignation.Id);
        }
    }

}
