namespace FrontToBack.Models
{
    public class ExpertProfessionFlowerExpert
    {
        public int Id { get; set; }
        public int ExpertProfessionId { get; set; }
        public ExpertProfession ExpertProfession { get; set; }
        public int FlowerExpertId { get; set; }
        public FlowerExpert FlowerExpert { get; set; }
    }
}
