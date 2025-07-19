using Domain.DbModels.MemberManagement;

using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repositories.Interfaces.MemberManagement;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Implementations.MemberManagement
{   
    public class UnregistrationRepository : Repository<Unregistration>, IUnregistrationRepository
    {
        public UnregistrationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
