using Domain.Common;
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
        public Int64 Id { get; set; }
        public int MembershipId { get; set; }
        public decimal LoanAmount { get; set; }
        public Int16 TenureId { get; set; } // Consider using enum  12/24/35/48/60 months
        public string LoanPurpose { get; set; }
        public DateTime ApplicationDate { get; set; }
        public Int16 ApplicationStatusId { get; set; } // Consider using enum   
        public decimal? ApprovedAmount { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public string Remarks { get; set; }

    }
}
