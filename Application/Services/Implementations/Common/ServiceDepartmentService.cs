using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public class ServiceDepartmentService : IServiceDepartmentService
    {
        private readonly IServiceDepartmentRepository repository;

        public ServiceDepartmentService(IServiceDepartmentRepository repository)
        {
            this.repository = repository;
        }

        public async Task<ServiceDepartment> AddServiceDepartmentAsync(ServiceDepartment objServiceDepartment)
        {
            return await repository.AddAsync(objServiceDepartment);
        }

        public async Task UpdateServiceDepartmentAsync(ServiceDepartment objServiceDepartment)
        {
            await repository.UpdateAsync(objServiceDepartment);
        }

        public async Task<IEnumerable<ServiceDepartment>> GetAllServiceDepartmentAsync()
        {
            return await repository.GetAllAsync();
        }

        public async Task<ServiceDepartment> GetServiceDepartmentByIdAsync(ServiceDepartment objServiceDepartment)
        {
            return await repository.GetByIdAsync(objServiceDepartment.Id);
        }
    }

}
