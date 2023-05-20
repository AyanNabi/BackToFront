using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataNotations.Models
{
    public class Group
    {
        [Required]
        public int Id { get; set; }

         [RegularExpression(@"^[A-Za-z]+$")]
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        [Editable(false)]
        public int MaxSize { get; set; }
    }
}

