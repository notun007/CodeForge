using Application.Services.Implementations.Expenditure;
using Application.Services.Interfaces.Common;
using Infrastructure.Persistence.Repositories.Interfaces.Accounting.Expenditure;
using Infrastructure.Persistence.Repositories.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Implementations.Accounting.Expenditure
{

    public class ExpenseService : IExpenseService
    {
        private readonly IExpenseRepository repository;

        public ExpenseService(IExpenseRepository countryRepository)
        {
            this.repository = countryRepository;
            //_mapper = mapper;
        }
    }
}
