using Domain.DbModels.Member;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Interfaces.Member
{
   
    public interface IMembershipRepository : IRepository<Domain.DbModels.Member.Membership>
    {
    }
}
