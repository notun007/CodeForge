using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IMaritalStatusService
    {
        Task<MaritalStatus> AddMaritalStatusAsync(MaritalStatus objMarital);
        Task UpdateMaritalStatusAsync(MaritalStatus objMarital);

        Task<IEnumerable<MaritalStatus>> GetAllMaritalStatusAsync();
        Task<MaritalStatus> GetMaritalStatusByIdAsync(MaritalStatus objMarital);
    }
}
