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
    [Table("ApplicationStatuses", Schema = "Common")]
    public class ApplicationStatus: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
