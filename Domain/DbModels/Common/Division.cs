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
    [Table("Divisions", Schema = "Common")]
    public class Division: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public Int16 CountryId { get; set; }
        public Country Country { get; set; }
        public virtual ICollection<District> Districts { get; set; }    
    }
}
