using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Member
{
    [Table("MembershipStatuses", Schema = "Member")]
    public class MembershipStatus
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
