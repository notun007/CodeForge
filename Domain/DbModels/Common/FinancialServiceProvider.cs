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
    [Table("FinancialServiceProviders", Schema = "Common")]
    public class FinancialServiceProvider: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        public string Name { get; set; }
        public Int16 FinancialServiceProviderTypeId { get; set; }
        public FinancialServiceProviderType FinancialServiceProviderType { get; set; }
    }
}
