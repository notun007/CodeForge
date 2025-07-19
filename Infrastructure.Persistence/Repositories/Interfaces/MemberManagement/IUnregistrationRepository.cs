using Domain.DbModels.MemberManagement;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Interfaces.MemberManagement
{   
    public interface IUnregistrationRepository : IRepository<Unregistration>
    {
    }
}
