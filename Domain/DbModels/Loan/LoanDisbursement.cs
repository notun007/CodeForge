using Domain.Common;
using Domain.DbModels.Common;
using Domain.DbModels.Member;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Loan
{
    [Table("LoanDisbursements", Schema = "Loan")]
    public class LoanDisbursement: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public Int64 MembershipId { get; set; }
        public Membership Membership { get; set; }
        public int LoanNumber { get; set; }
        public decimal LoanAmount { get; set; }
        public Int16 TenureId { get; set; } //Enum in Month
        public Tenure Tenure { get; set; } //Enum in Month
        public decimal InstallmentAmount { get; set; }
        public Int16 PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        [MaxLength(200)]
        public string? Remarks { get; set; }
        public int DisbursedBy { get; set; }
        public DateTime DisbursementDate { get; set; }
            
        public int? ApprovedBy { get; set; }
        public DateTime? ApprovedDate { get; set; }
    }
}
