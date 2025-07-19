using Domain.DbModels.Loan;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repositories.Interfaces.Loan;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Implementations.Loan
{   
    public class CollectionRepository : Repository<Collection>, ICollectionRepository
    {
        public CollectionRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
