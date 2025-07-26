using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Identity.Common;

namespace Domain.Identity.DbModels.Security
{
    [Table("Modules", Schema = "Security")]
    public class Module: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? NameBn { get; set; }
        [MaxLength(50)]
        public string Icon { get; set; }
        public Int16 SerialNo { get; set; }
    }
}
