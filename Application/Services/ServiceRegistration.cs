using Application.Services.Implementations;
using Application.Services.Implementations.Common;
using Application.Services.Interfaces;
using Application.Services.Interfaces.Common;
using Domain.Identity.DbModels.Security;
using Microsoft.Extensions.DependencyInjection;


namespace Application.Services
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddService(this IServiceCollection services)
        {
            services.AddScoped<ICountryService, CountryService>();
            services.AddScoped<IApplicationRoleService, ApplicationRoleService>();
            services.AddScoped<IModuleService, ModuleService>();
            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IMenuPermissionService, MenuPermissionService>();
                        
            return services;
        }
    }
}
