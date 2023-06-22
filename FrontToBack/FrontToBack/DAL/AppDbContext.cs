using FrontToBack.Models;
using FrontToBack.Models.Practice;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
namespace FrontToBack.DAL
{
    public class AppDbContext :IdentityDbContext<AppUser>//elave xusuisiyyeler vermishem deye onu artiq appuser kimi gorasun
    {
        public AppDbContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<SliderImage> SliderImages { get; set; }
        public DbSet<SliderContent> SliderContent { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<FlowerExpert> FlowerExperts { get; set; }
        public DbSet<ExpertProfession> ExpertProfessions { get; set; }
        public DbSet<ExpertProfessionFlowerExpert> ExpertProfessionFlowerExperts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogSlider> BlogSliders { get; set; }

        public DbSet<InstagramImagesSlider> InstagramImagesSlider { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<BookGenre> BookGenres { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Seed();
        //}















    }
}
