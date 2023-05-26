using Lab0526.DAL;
using Microsoft.AspNetCore.Mvc;

namespace Lab0526.Controllers
{
    public class HomeController : Controller
    {
        readonly AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
