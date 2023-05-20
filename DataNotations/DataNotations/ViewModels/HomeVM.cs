using DataNotations.Models;
using System.Collections.Generic;

namespace DataNotations.ViewModels
{
    public class HomeVM
    {
        public List<Student> Students { get; set; }
        public List<Group> Group { get; set; }
    }
}
