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

namespace Domain.DbModels.Saving
{
    [Table("Deposits", Schema = "Saving")]
    public class Deposit: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public Int64 MembershipId { get; set; }
        public Membership Membership { get; set; }
        public decimal Amount { get; set; }
        public DateTime DepositDate { get; set; }
        public Int16 PaymentMethodId { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public string Remarks { get; set; }
    }
}
