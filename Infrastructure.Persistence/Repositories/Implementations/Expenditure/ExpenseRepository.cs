using Domain.DbModels.Common;
using Domain.DbModels.Expenditure;
using Infrastructure.Persistence.Contexts;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Expenditure;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Implementations.Expenditure
{    
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {
        public ExpenseRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
