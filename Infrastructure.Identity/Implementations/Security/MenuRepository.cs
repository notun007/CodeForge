using Domain.Identity.DbModels.Security;
using Infrastructure.Identity.Context;
using Infrastructure.Identity.Interfaces.Security;
using Infrastructure.Shared.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity.Implementations.Security
{
    public class MenuRepository : Repository<IdentityContext, Menu>, IMenuRepository
    {
        public MenuRepository(IdentityContext dbContext) : base(dbContext)
        {
        }
    }

}
