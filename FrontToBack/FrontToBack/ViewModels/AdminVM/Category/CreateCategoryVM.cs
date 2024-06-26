﻿using System.ComponentModel.DataAnnotations;

namespace FrontToBack.ViewModels.AdminVM.Category
{
    public class CreateCategoryVM
    {
        [Required]
        [StringLength(15)]
        public string Name { get; set; }
        [Required]
        [MinLength(5, ErrorMessage = "5den kicikdir")]
        public string Desc { get; set; }
    }
}
