using Domain.DbModels.MemberManagement;
using Domain.DbModels.Saving;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Interfaces.Saving
{   
    public interface IDepositRepository : IRepository<Deposit>
    {
    }
}
