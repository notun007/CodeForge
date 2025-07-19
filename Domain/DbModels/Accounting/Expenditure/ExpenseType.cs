using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Accounting.Expenditure
{
    public class ExpenseType: BaseEntity
    {
        public Int16 Id { get; set; }
        public string Name { get; set; }
    }
}
