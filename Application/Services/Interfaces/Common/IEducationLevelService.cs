using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IEducationLevelService
    {
        Task<EducationLevel> AddEducationLevelAsync(EducationLevel objEducationLevel);
        Task UpdateEducationLevelAsync(EducationLevel objEducationLevel);

        Task<IEnumerable<EducationLevel>> GetAllEducationLevelAsync();
        Task<EducationLevel> GetEducationLevelByIdAsync(EducationLevel objEducationLevel);
    }
}
