using FrontToBack.DAL;
using FrontToBack.Services;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
   readonly AppDbContext _appDbContext;
        readonly ISum _sumservice;
        readonly UserAccount _account;



        public HomeController(AppDbContext appDbContext, ISum sumservice, UserAccount account)
        {
            _appDbContext=appDbContext;
            _sumservice = sumservice;
            _account = account;

        }

        public IActionResult Index()
        {
            HomeVM homevm = new HomeVM();
            homevm.SliderImages = _appDbContext.SliderImages.ToList();
            homevm.SliderContent = _appDbContext.SliderContent.AsNoTracking().FirstOrDefault();
            homevm.Products = _appDbContext.Products.Include(p=>p.ProductImages).Take(4).ToList();
            homevm.Categories = _appDbContext.Categories.ToList();
            homevm.FlowerExperts = _appDbContext.FlowerExperts
              .Include(fe => fe.ExpertProfessionFlowerExperts)
              .ThenInclude(ef => ef.ExpertProfession)
              .ToList();
            homevm.Blogs = _appDbContext.Blogs.ToList();
            homevm.BlogSliders = _appDbContext.BlogSliders.ToList();
            homevm.InstagramImagesSliders = _appDbContext.InstagramImagesSlider.ToList();
           var list= _appDbContext.ChangeTracker.Entries().ToList();
            _appDbContext.SaveChanges();

            var sum = _sumservice.Sum(1, 2);

            return View(homevm);
        }
    }
}
