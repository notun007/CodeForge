using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class ServiceDivisionService : IServiceDivisionService
    {
        private readonly IServiceDivisionRepository repository;

        public ServiceDivisionService(IServiceDivisionRepository repository)
        {
            this.repository = repository;
        }

        public async Task<ServiceDivision> AddServiceDivisionAsync(ServiceDivision objServiceDivision)
        {
            return await repository.AddAsync(objServiceDivision);
        }

        public async Task UpdateServiceDivisionAsync(ServiceDivision objServiceDivision)
        {
            await repository.UpdateAsync(objServiceDivision);
        }

        public async Task<IEnumerable<ServiceDivision>> GetAllServiceDivisionAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<ServiceDivision> GetServiceDivisionByIdAsync(ServiceDivision objServiceDivision)
        {
            return await repository.GetByIdAsync(objServiceDivision.Id);
        }
    }

}
