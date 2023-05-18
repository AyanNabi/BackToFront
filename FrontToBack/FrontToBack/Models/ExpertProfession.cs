using System.Collections.Generic;

namespace FrontToBack.Models
{
    public class ExpertProfession
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ExpertProfessionFlowerExpert> ExpertProfessionFlowerExperts { get; set; }
    }
}
