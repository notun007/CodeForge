using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identity.ViewModels.Security
{
    public class ChildMenuViewModel
    {
        public string label { get; set; }
        public string? labelBn { get; set; }
        public string? icon { get; set; }
        public string? routerLink { get; set; }
        public int SecModuleId { get; set; }
        public int? ParentMenuId { get; set; }
        public int? ParentSerialNo { get; set; }
        public int? ChildSerialNo { get; set; }
    }
}
