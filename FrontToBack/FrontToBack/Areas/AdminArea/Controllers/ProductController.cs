using FrontToBack.DAL;
using FrontToBack.Helper;
using FrontToBack.Models;
using FrontToBack.ViewModels.AdminVM.Category;
using FrontToBack.ViewModels.AdminVM.Product;
using Microsoft.AspNetCore.Hosting;
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
        readonly IWebHostEnvironment _webHostEnvironment;

        public ProductController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;   
        }
        public IActionResult Index()
        {
            var products = _appDbContext.Products
               .Where(c => c.IsDeleted == false)
                 .Include(p => p.ProductImages)
                 .Include(p => p.category)
                 .ToList();    
               
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
            //if (ModelState.IsValid) return View();
            Product product = new Product();

            foreach (var item in createProductVM.Photos)
            {
                if (!item.CheckFileType())
                {
                    ModelState.AddModelError("", "Tip sehvdir");
                    return View();
                }

                if (!item.CheckFileSize(1000))
                {
                    ModelState.AddModelError("", "Olcusu boyukdur");
                    return View();
                }
               
                ProductImage image = new ProductImage();
                if (item == createProductVM.Photos.FirstOrDefault())
                {
                    image.IsMainImage = true;

                }
                image.ImageUrl = item.SaveImage(_webHostEnvironment, "img");
                product.ProductImages.Add(image);   

            }
            //select option uchun viewbag gonder
            ViewBag.Categories = _appDbContext.Categories.ToList();
            ViewBag.Categories = new SelectList(_appDbContext.Categories.ToList(), "Id", "Name");

            product.Name = createProductVM.Name;    
            product.Price = createProductVM.Price;
            product.Count = createProductVM.Count;

            product.CategoryId = createProductVM.CategoryId;
            _appDbContext.Products.Add(product);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return NotFound();
            var product = _appDbContext.Products
                 .Include(p => p.ProductImages).FirstOrDefault(c => c.Id == id);
            if (product == null) return NotFound();
            product.IsDeleted = true;
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        

         }



        public IActionResult Update(int? id)
        {

            ViewBag.Categories = new SelectList(_appDbContext.Categories.ToList(), "Id", "Name");

            if (id == null) return NotFound();
            var product = _appDbContext.Products.Include(p => p.ProductImages).FirstOrDefault(c => c.Id == id);
            if (product == null) return NotFound();

            return View(new UpdateProductVM()
            {
                Name = product.Name,
                Price = product.Price,
                Count = product.Count,
                CategoryId = product.CategoryId




            });

        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]// qiraqdan sorgulara cavab vermir inputun valuesi=undan istifade edir
        public IActionResult Update(int? id, UpdateProductVM updateProduct)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var exist = _appDbContext.Categories.Any(c => c.Name.ToLower() == updateProduct.Name.ToLower() && c.Id != id

            );
            if (exist)
            {
                ModelState.AddModelError("Name", "Bu adli category movcuddur");

            }
            if (id == null) return NotFound();
            var dbproduct = _appDbContext.Products.FirstOrDefault(c => c.Id == id);

            if (dbproduct == null) return NotFound();
            //if (dbproduct != null) return RedirectToAction("Delete");


            dbproduct.Price = updateProduct.Price;
            dbproduct.Count = updateProduct.Count;
            dbproduct.CategoryId = updateProduct.CategoryId;
            dbproduct.Name = updateProduct.Name;
            _appDbContext.SaveChanges();

            return RedirectToAction("Index");

        }


        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var product = _appDbContext.Products
                .Include(c => c.ProductImages)
                .FirstOrDefault(c => c.Id == id);
            if (product == null) return NotFound();
            return View(product);
        }



        public IActionResult RemoveImage(int? id)
        {

            if (id == null) return NotFound();
            var image = _appDbContext.ProductImages
                .FirstOrDefault(c => c.Id == id);
            if (image == null) return NotFound();
            _appDbContext.ProductImages.Remove(image);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));


        }




        }
}
