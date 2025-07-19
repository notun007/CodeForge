using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Common
{
    [Table("PaymentMethods", Schema = "Common")]
    public class PaymentMethod: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }

        public Int16? FinancialServiceProviderId { get; set; }
        public FinancialServiceProvider FinancialServiceProvider { get; set; }
        public Int16? PaymentChannelId { get; set; }
        public PaymentChannel PaymentChannel { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public decimal? PaymentChargePercent { get; set; }
        
    }
}
