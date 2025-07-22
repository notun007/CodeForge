using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Common
{
    public interface IGenderService
    {
        Task<Gender> AddGenderAsync(Gender objGender);
        Task UpdateGenderAsync(Gender objGender);

        Task<IEnumerable<Gender>> GetAllGenderAsync();
        Task<Gender> GetGenderByIdAsync(Gender objGender);
    }
}
