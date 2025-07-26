using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Identity.Common;

namespace Domain.Identity.DbModels.Security
{
    [Table("Menus", Schema = "Security")]
    public class Menu:BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int16 Id { get; set; }
        [StringLength(128)]
        public string? TitleBn { get; set; } = string.Empty;
        [Required(ErrorMessage = "Menu Title is required.")]
        [StringLength(128)]
        public string Title { get; set; } = string.Empty;
        [StringLength(256)]
        public string? Link { get; set; }
        public int? ParentMenuId { get; set; }
        public Int16 SecModuleId { get; set; }
        public Int16 ParentSerialNo { get; set; }
        public Int16 ChildSerialNo { get; set; }
        public Int16 LevelNo { get; set; }
        [StringLength(1)]
        public bool IsParent { get; set; }
        [StringLength(256)]
        public string? Icon { get; set; }
        public bool IsModule { get; set; }
    }
}
