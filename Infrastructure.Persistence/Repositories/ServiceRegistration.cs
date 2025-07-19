using Infrastructure.Persistence.Repositories.Implementations;
using Infrastructure.Persistence.Repositories.Implementations.Common;
using Infrastructure.Persistence.Repositories.Interfaces;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services)
        {
            services.AddScoped<ICountryRepository, CountryRepository>();
           
            // Add more infrastructure-related services

            return services;
        }
    }
}
