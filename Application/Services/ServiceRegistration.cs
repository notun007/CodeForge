using Application.Services.Implementations.Common;
using Application.Services.Interfaces.Common;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddScoped<ICountryService, CountryService>();
            
            // Add more application-level services here

            return services;
        }
    }
}
