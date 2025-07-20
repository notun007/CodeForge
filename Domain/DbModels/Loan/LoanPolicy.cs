using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DbModels.Common;

namespace Domain.DbModels.Loan
{
    [Table("LoanPolicies", Schema = "Loan")]
    public class LoanPolicy: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public decimal MinimumLoanAmount { get; set; }
        public decimal MaximumLoanAmount { get; set; }
        public decimal LoanSanctionRatio { get; set; }
        public decimal MinimumSavingsRequirement { get; set; }
        public Int16 LoanEligibilityTenureId { get; set; }
        public Tenure LoanEligibilityTenure { get; set; }
        public Int16 DefaultLoanTenureId { get; set; }
        public Tenure DefaultLoanTenure { get; set; }
        public Int16 MaximumLoanTenureId { get; set; }
        public Tenure MaximumLoanTenure { get; set; }
        public decimal ProcessingFeeRate { get; set; }
        public Int16 MaxActiveLoansPerMember { get; set; }
        public int InstallmentFrequencyId { get; set; }
        public InstallmentFrequency InstallmentFrequency { get; set; }
        public int GracePeriodMonths { get; set; }
        public decimal PenaltyRateLateInstallment { get; set; }
        public string? LoanAccountPrefix { get; set; }
    }
}
