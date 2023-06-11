using System.Collections.Generic;

namespace FrontToBack.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int Count { get; set; }
        public Category category { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
