
using System.ComponentModel.DataAnnotations;

namespace FrontToBack.ViewModels.AdminVM.Category
{
    public class CategoryUpdateVM
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "5den kicikdir")]
        public string Desc { get; set; }
    }
}
