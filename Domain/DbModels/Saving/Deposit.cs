using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Saving
{
    [Table("Deposits", Schema = "Saving")]
    public class Deposit: BaseEntity
    {
        public Int64 Id { get; set; }
        public Int64 Registration { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public decimal InterestRate { get; set; }
        public bool IsInterestApplicable { get; set; }
        public decimal InterestAccrued { get; set; }
        public DateTime? LastInterestCalculationDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime OpeningDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
