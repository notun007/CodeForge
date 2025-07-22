using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IUnionService
    {
        Task<Union> AddUnionAsync(Union objUnion);
        Task UpdateUnionAsync(Union objUnion);

        Task<IEnumerable<Union>> GetAllUnionAsync();
        Task<Union> GetUnionByIdAsync(Union objUnion);
    }
}
