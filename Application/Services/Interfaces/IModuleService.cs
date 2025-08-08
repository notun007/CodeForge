using Application.Services.Implementations;
using Domain.DbModels.Common;
using Domain.Identity.DbModels.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IModuleService
    {
        Task<Module> AddModuleAsync(Module objModule);
        Task UpdateModuleAsync(Module objModule);
        Task<IEnumerable<Module>> GetAllModuleAsync();
        Task<Module> GetModuleByIdAsync(Module objModule);

    }
}
