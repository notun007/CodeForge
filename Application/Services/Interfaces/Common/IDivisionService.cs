using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IDivisionService
    {
        Task<Division> AddDivisionAsync(Division objDivision);
        Task UpdateDivisionAsync(Division objDivision);

        Task<IEnumerable<Division>> GetAllDivisionAsync();
        Task<Division> GetDivisionByIdAsync(Division objDivision);
    }
}
