using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IReligionService
    {
        Task<Religion> AddReligionAsync(Religion objReligion);
        Task UpdateReligionAsync(Religion objReligion);

        Task<IEnumerable<Religion>> GetAllReligionAsync();
        Task<Religion> GetReligionByIdAsync(Religion objReligion);
    }
}
