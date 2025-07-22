using Application.Services.Interfaces.Common;
using Domain.DbModels.Common;
using Infrastructure.Persistence.Repositories.Interfaces;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace Application.Services.Implementations.Common
{   
    public class CountryService: ICountryService
    {
        private readonly ICountryRepository repository;

        public CountryService(ICountryRepository repository)
        {
           this.repository = repository;
            //_mapper = mapper;
        }

        public async Task<Country> AddCountryAsync(Country objCountry)
        {
           return await repository.AddAsync(objCountry);
        }

        public async Task UpdateCountryAsync(Country objCountry)
        {
            await repository.UpdateAsync(objCountry);
        }

        public async Task<IEnumerable<Country>> GetAllCountryAsync()
        {
           return await repository.GetAllAsync();
        }

        public async Task<Country> GetCountryByIdAsync(Country objCountry)
        {
           return await repository.GetByIdAsync(objCountry.Id);
        }       
    }
}
