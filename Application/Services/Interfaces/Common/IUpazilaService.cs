using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IUpazilaService
    {
        Task<Upazila> AddUpazilaAsync(Upazila objUpazila);
        Task UpdateUpazilaAsync(Upazila objUpazila);

        Task<IEnumerable<Upazila>> GetAllUpazilaAsync();
        Task<Upazila> GetUpazilaByIdAsync(Upazila objUpazila);
    }
}
