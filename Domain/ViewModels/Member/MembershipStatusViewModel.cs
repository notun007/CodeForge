using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels.Member
{
    [Table("Statuses", Schema = "Membership")]
    public class MembershipStatusViewModel
    {
        public string Name { get; set; }
    }
}
