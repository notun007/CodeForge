using Domain.DbModels.Common;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Interfaces.Common
{  
    public interface IPaymentMethodRepository : IRepository<PaymentMethod>
    {
    }
}
