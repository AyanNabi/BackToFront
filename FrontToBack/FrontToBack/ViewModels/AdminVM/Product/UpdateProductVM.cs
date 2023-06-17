using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrontToBack.ViewModels.AdminVM.Product
{
    public class UpdateProductVM
    {
        
        public string Name { get; set; }
      
        public double Price { get; set; }

        public int CategoryId { get; set; }
        public int Count { get; set; }

   
        public List<IFormFile> Photos { get; set; }

        public UpdateProductVM()
        {
            Photos = new List<IFormFile>(); 
        }

      
    }
}
