using InMemoryDatabase.Models;
using System.Collections.Generic;

namespace InMemoryDatabase.DAL.Interfaces
{
    public interface IAuthorRepository
    {
        public List<Author> GetAuthors();
    }
}
