using System.Collections.Generic;

namespace FrontToBack.Models
{
    public class FlowerExpert
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public List<ExpertProfessionFlowerExpert> ExpertProfessionFlowerExperts { get; set; }
    }
}
