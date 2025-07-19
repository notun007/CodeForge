using Domain.Common;
using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Accounting.Expenditure
{
    [Table("Expenses", Schema = "Accounting")]
    public class Expense : BaseEntity
    {
        public Int64 Id { get; set; }
        public Int16 ExpenseTypeId { get; set; } // Rent, Utilities, LoanFee, etc.
        public ExpenseType ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public Int16 PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string ReferenceNumber { get; set; }
        public string PaidTo { get; set; }
        public string Description { get; set; }
        public string ApprovedBy { get; set; }
        public string ApprovedDate { get; set; }
        public bool IsRecurring { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}
