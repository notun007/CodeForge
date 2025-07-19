using Domain.DbModels.Welfare;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Interfaces.Welfare
{  
    public interface IDisbursementRepository : IRepository<Disbursement>
    {
    }
}
