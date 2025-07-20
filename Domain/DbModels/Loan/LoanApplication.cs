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
    [Table("LoanApplications", Schema = "Loan")]
    public class LoanApplication: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public Int64 MembershipId { get; set; }
        public Membership Membership { get; set; }
        public decimal LoanAmount { get; set; }
        public Int16? TenureId { get; set; } // Consider using enum  12/24/35/48/60 months
        public Tenure Tenure { get; set; }
        [MaxLength(200)]
        public string? LoanPurpose { get; set; }
        public DateTime? ApplicationDate { get; set; }
        public Int16 ApplicationStatusId { get; set; } // Consider using enum   
        public ApplicationStatus ApplicationStatus { get; set; } // Consider using enum   
        public decimal? ApprovedAmount { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? ApprovedBy { get; set; }
        [MaxLength(200)]
        public string? Remarks { get; set; }

    }
}
