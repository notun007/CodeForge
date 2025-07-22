using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IOccupationService
    {
        Task<Occupation> AddOccupationAsync(Occupation objOccupation);
        Task UpdateOccupationAsync(Occupation objOccupation);

        Task<IEnumerable<Occupation>> GetAllOccupationAsync();
        Task<Occupation> GetOccupationByIdAsync(Occupation objOccupation);
    }
}
