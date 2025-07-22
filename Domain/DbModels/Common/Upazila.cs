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
    [Table("Upazilas", Schema = "Common")]
    public class Upazila: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        public Int16 DistrictId { get; set; }
        public District District { get; set; }
        public virtual ICollection<Union> Unions { get; set; }
    }
}
