using FrontToBack.DAL;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
   readonly AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext=appDbContext;
        }

        public IActionResult Index()
        {
            HomeVM homevm = new HomeVM();
            homevm.SliderImages = _appDbContext.SliderImages.ToList();
            homevm.SliderContent = _appDbContext.SliderContent.FirstOrDefault();
            homevm.Products = _appDbContext.Products.Include(p=>p.ProductImages).Take(4).ToList();
            homevm.Categories = _appDbContext.Categories.ToList();
            homevm.FlowerExperts = _appDbContext.FlowerExperts
              .Include(fe => fe.ExpertProfessionFlowerExperts)
              .ThenInclude(ef => ef.ExpertProfession)
              .ToList();
            homevm.Blogs = _appDbContext.Blogs.ToList();
            homevm.BlogSliders = _appDbContext.BlogSliders.ToList();
            homevm.InstagramImagesSliders = _appDbContext.InstagramImagesSlider.ToList();


            return View(homevm);
        }
    }
}
