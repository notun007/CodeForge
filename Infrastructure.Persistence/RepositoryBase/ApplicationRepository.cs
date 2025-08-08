using Infrastructure.Persistence.Contexts;
using Infrastructure.Shared.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.RepositoryBase
{
    public class ApplicationRepository<TEntity> : Repository<ApplicationDbContext, TEntity>, IApplicationRepository<TEntity>
    where TEntity : class
    {
        public ApplicationRepository(ApplicationDbContext context) : base(context) { }
    }
}
