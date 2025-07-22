using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IDesignationService
    {
        Task<Designation> AddDesignationAsync(Designation objDesignation);
        Task UpdateDesignationAsync(Designation objDesignation);

        Task<IEnumerable<Designation>> GetAllDesignationAsync();
        Task<Designation> GetDesignationByIdAsync(Designation objDesignation);
    }
}
