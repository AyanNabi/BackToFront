using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FrontToBack.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<SliderContent> SliderContent { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }



    }
}
