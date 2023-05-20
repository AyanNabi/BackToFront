using DataNotations.Models;
using Microsoft.EntityFrameworkCore;

namespace DataNotations.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }

    }
}
