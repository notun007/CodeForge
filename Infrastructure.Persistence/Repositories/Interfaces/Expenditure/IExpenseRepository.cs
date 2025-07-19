using Domain.DbModels.Common;
using Domain.DbModels.Expenditure;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Interfaces.Expenditure
{  
    public interface IExpenseRepository : IRepository<Expense>
    {
    }
}
