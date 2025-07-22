using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IServiceDepartmentService
    {
        Task<ServiceDepartment> AddServiceDepartmentAsync(ServiceDepartment objServiceDepartment);
        Task UpdateServiceDepartmentAsync(ServiceDepartment objServiceDepartment);

        Task<IEnumerable<ServiceDepartment>> GetAllServiceDepartmentAsync();
        Task<ServiceDepartment> GetServiceDepartmentByIdAsync(ServiceDepartment objServiceDepartment);
    }
}
