using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.DbModels.Common;

namespace Domain.DbModels.Saving
{
    public class SavingPolicy: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int64 Id { get; set; }
        public decimal DefaultSavingAmount { get; set; }
        public Int16 DefaultStartDay { get; set; }
        public Int16 GracePeriodDays { get; set; }
        public bool PenaltyEnabled { get; set; }
        public decimal? PenaltyRate { get; set; }
        public Int16 PaymentFrequencyId { get; set; }  // e.g., "Monthly", "Quarterly"
        public PaymentFrequency PaymentFrequency { get; set; }
        public bool EnablePartialSaving { get; set; }
    }
}
