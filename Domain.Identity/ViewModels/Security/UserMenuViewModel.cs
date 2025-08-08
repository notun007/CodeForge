using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Identity.ViewModels.Security
{
    public class UserMenuViewModel
    {
        public string label { get; set; }
        public string? labelBn { get; set; }
        public string? Icon { get; set; }
        public List<ChildMenuViewModel> items { get => _items; set => _items = value; }

        private List<ChildMenuViewModel> _items = new List<ChildMenuViewModel>();
    }
}
