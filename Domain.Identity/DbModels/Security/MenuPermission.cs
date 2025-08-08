using Domain.Identity.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identity.DbModels.Security
{
    [Table("MenuPermissions", Schema = "Security")]
    public class MenuPermission: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        public int? SecRoleId { get; set; }
        [MaxLength(450)]
        public string? SecUserId { get; set; }
        public int SecMenuId { get; set; }
        public bool Add { get; set; }
        public bool Read { get; set; }
        public bool Edit { get; set; }
        public bool Delete { get; set; }
        public bool Print { get; set; }        
    }
}
