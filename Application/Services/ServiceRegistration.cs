using Application.Services.Implementations;
using Application.Services.Implementations.Common;
using Application.Services.Interfaces;
using Application.Services.Interfaces.Common;
using Microsoft.Extensions.DependencyInjection;


namespace Application.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IModuleService, ModuleService>();
            services.AddScoped<IMenuService, MenuService>();
            // Add more application-level services here

            return services;
        }
    }
}
