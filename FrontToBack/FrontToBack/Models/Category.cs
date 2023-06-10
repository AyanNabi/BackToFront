using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FrontToBack.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]  
        public string Name { get; set; }
        [Required]
        [MinLength(5, ErrorMessage ="5den kicikdir")]
        public string Desc { get; set; }
        public bool IsDeleted { get; set; }
        public List<Product>? Products { get; set; }
    }
}
