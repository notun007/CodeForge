using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IServiceDivisionService
    {
        Task<ServiceDivision> AddServiceDivisionAsync(ServiceDivision objServiceDivision);
        Task UpdateServiceDivisionAsync(ServiceDivision objServiceDivision);

        Task<IEnumerable<ServiceDivision>> GetAllServiceDivisionAsync();
        Task<ServiceDivision> GetServiceDivisionByIdAsync(ServiceDivision objServiceDivision);
    }
}
