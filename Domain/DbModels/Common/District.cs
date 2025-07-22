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
    [Table("Districts", Schema = "Common")]
    public class District: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        public Int16 DivisionId { get; set; }
        public Division Division { get; set; }
        public virtual ICollection<Upazila> Upazilas { get; set; }
    }
}
