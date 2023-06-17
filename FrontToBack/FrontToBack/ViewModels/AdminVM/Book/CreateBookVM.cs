using System.Collections.Generic;

namespace FrontToBack.ViewModels.AdminVM.Book
{
    public class CreateBookVM
    {
        public string Name { get; set; }
        public List<int>    GenreIds { get; set; }
    }
}
