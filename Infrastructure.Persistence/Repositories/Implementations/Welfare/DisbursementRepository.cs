using Domain.DbModels.Welfare;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repositories.Interfaces.Welfare;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Implementations.Welfare
{
 
    public class DisbursementRepository : Repository<Disbursement>, IDisbursementRepository
    {
        public DisbursementRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
