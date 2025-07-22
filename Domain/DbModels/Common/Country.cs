using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Common
{
    [Table("Countries", Schema = "Common")]
    public class Country: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(5)]
        public string ShortName { get; set; }
        public virtual ICollection<Division> Divisions { get; set; }
        
    }
}
