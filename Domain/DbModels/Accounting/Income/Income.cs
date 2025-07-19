using Domain.Common;
using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Accounting.Income
{
    public class Income: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 IncomeTypeId { get; set; }
        public IncomeType IncomeType { get; set; }
        public decimal Amount { get; set; }
        public Int16 PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string ReferenceNumber { get; set; }
        public string ReceivedFrom { get; set; }
        public string Description { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedDate { get; set; }
        public bool IsRecurring { get; set; }
        public DateTime IncomeDate { get; set; }

    }
}
