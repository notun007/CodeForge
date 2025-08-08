using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class BaseEntity
    {      
        public bool IsActive { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
        public bool? IsDeleted { get; set; }
        public int? DeleteBy { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int? UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }

    }
}
