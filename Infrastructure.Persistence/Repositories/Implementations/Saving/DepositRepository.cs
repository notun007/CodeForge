using Domain.DbModels.MemberManagement;
using Domain.DbModels.Saving;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repositories.Interfaces.MemberManagement;
using Infrastructure.Persistence.Repositories.Interfaces.Saving;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Implementations.Saving
{ 
    public class DepositRepository : Repository<Deposit>, IDepositRepository
    {
        public DepositRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
