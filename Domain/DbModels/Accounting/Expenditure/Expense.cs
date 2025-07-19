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
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public Int16 ExpenseTypeId { get; set; } // Rent, Utilities, LoanFee, etc.
        public ExpenseType ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public Int16 PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        [MaxLength(100)]
        public string ReferenceNumber { get; set; }
        [MaxLength(200)]
        public string? PaidTo { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public bool IsRecurring { get; set; }
        public DateTime ExpenseDate { get; set; }
    }
}
