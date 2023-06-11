using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels.AdminVM.Product;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FrontToBack.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class ProductController : Controller
    {

        readonly AppDbContext _appDbContext;
        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var products = _appDbContext.Products
                 .Include(p => p.ProductImages)
                 .Include(p => p.category).ToList();    
               
            return View(products);
        }

        public IActionResult Create()
        {

            ViewBag.Categories = _appDbContext.Categories.ToList();
            ViewBag.Categories = new SelectList(_appDbContext.Categories.ToList(), "Id", "Name");

            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateProductVM createProductVM)
        {

            ViewBag.Categories = _appDbContext.Categories.ToList();
            ViewBag.Categories = new SelectList(_appDbContext.Categories.ToList(), "Id", "Name");
            Product product = new Product();
            product.Name = createProductVM.Name;    
            product.Price = createProductVM.Price;
            product.CategoryId = createProductVM.CategoryId;
            _appDbContext.Products.Add(product);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
