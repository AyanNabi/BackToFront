using Microsoft.EntityFrameworkCore;

namespace DataNotations.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( DbContextOptions options) : base(options)
        {
        }
    }
}
