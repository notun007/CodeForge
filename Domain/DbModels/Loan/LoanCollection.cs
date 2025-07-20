using Domain.Common;
using Domain.DbModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Loan
{
    [Table("LoanCollection", Schema = "Loan")]
    public class LoanCollection: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        
        public Int64 LoanDisbursementId { get; set; }
        public LoanDisbursement LoanDisbursement { get; set; }
        public decimal CollectionAmount { get; set; }
        public decimal? PenaltyAmount { get; set; }
        public decimal? OtherCharges { get; set; }
        public Int16 PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        [MaxLength(100)]
        public string ReferenceNumber { get; set; }
        public int CollectedBy { get; set; }
        public DateTime CollectionDate { get; set; }
        [MaxLength(200)]
        public string Remarks { get; set; }
        public bool IsAdvancePayment { get; set; }
        public DateTime? DueDate { get; set; }

    }
}
