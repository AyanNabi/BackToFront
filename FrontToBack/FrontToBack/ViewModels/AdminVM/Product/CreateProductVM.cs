using FrontToBack.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrontToBack.ViewModels.AdminVM.Product
{
    public class CreateProductVM
    {
        [Required, StringLength(100)]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public int Count { get; set; }
        [Required, ]
        public IFormFile[] Photos { get; set; }
    }
}
