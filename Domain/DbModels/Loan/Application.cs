using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DbModels.Loan
{
    [Table("Applications", Schema = "Loan")]
    public class Application: BaseEntity
    {
        public Int64 Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
    }
}
