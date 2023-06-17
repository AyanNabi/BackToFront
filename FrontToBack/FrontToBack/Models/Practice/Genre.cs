using System.Collections.Generic;

namespace FrontToBack.Models.Practice
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookGenre> BookGenres { get; set; }

    }
}
