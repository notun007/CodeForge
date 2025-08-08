
using Domain.Identity.DbModels.Security;
using Infrastructure.Identity.Context;
using Infrastructure.Identity.Interfaces.Security;
using Infrastructure.Shared.GenericRepository;
//using Infrastructure.Identity.Context;

namespace Infrastructure.Persistence.Repositories.Implementations.Security
{
    public class ModuleRepository : Repository<IdentityContext, Module>, IModuleRepository
    {    
        public ModuleRepository(IdentityContext dbContext) : base(dbContext)
        {
        }
    }
}
