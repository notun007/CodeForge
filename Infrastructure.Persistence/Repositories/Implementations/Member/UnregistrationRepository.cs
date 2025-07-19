using Domain.DbModels.Member;

using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repositories.Interfaces.Member;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Implementations.Member
{   
    public class UnregistrationRepository : Repository<Unregistration>, IUnregistrationRepository
    {
        public UnregistrationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
