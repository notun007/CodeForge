﻿
using Domain.DbModels.Loan;
using Infrastructure.Persistence.RepositoryBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Repositories.Interfaces.Loan
{   
    public interface ILoanApplicationRepository : IRepository<LoanApplication>
    {
    }
}
