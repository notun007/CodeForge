using Domain.DbModels.Common;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Implementations.Common
{ 
    public class OccupationRepository : Repository<Occupation>, IOccupationRepository
    {
        public OccupationRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
