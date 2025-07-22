using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IDistrictService
    {
        Task<District> AddDistrictAsync(District objDistrict);
        Task UpdateDistrictAsync(District objDistrict);

        Task<IEnumerable<District>> GetAllDistrictAsync();
        Task<District> GetDistrictByIdAsync(District objDistrict);
    }
}
