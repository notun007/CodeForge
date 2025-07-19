using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Implementations.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces.Common
{
    public interface ICountryService
    {
        Task<Country> AddCountryAsync(Country objCountry);
        Task UpdateCountryAsync(Country objCountry);

        Task<IEnumerable<Country>> GetAllCountryAsync();
        Task<Country> GetCountryByIdAsync(Country objCountry);
        
    }
}
