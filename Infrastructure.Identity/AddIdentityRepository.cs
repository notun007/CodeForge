using Infrastructure.Identity.Implementations.Security;
using Infrastructure.Identity.Interfaces.Security;
using Infrastructure.Persistence.Repositories.Implementations.Security;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity
{
    public static class IdentityRepositoryRegistration
    {
        public static IServiceCollection AddIdentityRepository(this IServiceCollection services)
        {
            services.AddScoped<IApplicationRoleRepository, ApplicationRoleRepository>();
            services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IMenuPermissionRepository, MenuPermissionRepository>();

            return services;
        }
    }
}
