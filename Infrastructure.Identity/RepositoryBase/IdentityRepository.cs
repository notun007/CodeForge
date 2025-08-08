using Infrastructure.Identity.Context;
using Infrastructure.Shared.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Identity.RepositoryBase
{
    public class IdentityRepository<TEntity> : Repository<IdentityContext, TEntity>, IIdentityRepository<TEntity>
    where TEntity : class
    {
        public IdentityRepository(IdentityContext context) : base(context) { }
    }
}
