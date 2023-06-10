using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontToBack.Models
{
    public class BlogSlider
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Profession { get; set; }
        [NotMapped ]
        public IFormFile Photo { get; set; }

    }
}
