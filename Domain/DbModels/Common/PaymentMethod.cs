using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Common
{
    public class PaymentMethod: BaseEntity
    {
        public Int16 Id { get; set; }   
        public string Name { get; set; }
    }
}
