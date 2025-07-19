using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Accounting.Income
{
    public class IncomeType: BaseEntity
    {
        public Int16 Id { get; set; }
        public string Name { get; set; }
    }
}
