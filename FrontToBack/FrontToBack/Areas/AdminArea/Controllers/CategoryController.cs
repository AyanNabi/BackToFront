using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels.AdminVM.Category;
using FrontToBack.ViewModels.AdminVM.Category;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

using System.Runtime.InteropServices.WindowsRuntime; 

namespace FrontToBack.Areas.AdminArea.Controllers
{

    [Area("AdminArea")]
    public class CategoryController : Controller
    {
        readonly AppDbContext _appDbContext;
        public CategoryController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {

            var categories = _appDbContext.Categories.Where(c => c.IsDeleted == false).ToList();

            return View(categories);
        }

        public IActionResult Detail(int?id)
        {
            if (id == null) return NotFound();
            var category= _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
            if(category==null)return NotFound();
            return View(category);
        }

        public IActionResult Delete(int? id)
        {

            if (id == null) return NotFound();
            var category = _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            //_appDbContext.Categories.Where(c=>c.IsDeleted==false).ToList();
            //_appDbContext.Categories.Remove(category);
            category.IsDeleted = true;
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create(int?id)
        {

            return View();
        }

            [HttpPost]
        [AutoValidateAntiforgeryToken]// qiraqdan sorgulara cavab vermir inputun valuesi=undan istifade edir
        public IActionResult Create(CreateCategoryVM category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var exist= _appDbContext.Categories.Any(c=>c.Name.ToLower()==category.Name.ToLower());
            if (exist)
            {
                ModelState.AddModelError("Name", "Bu adli category movcuddur");

            }
            Category c = new Category()
            {
                Name= category.Name,    
                Desc=category.Desc, 

            };

            _appDbContext.Categories.Add(c);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));

            
        }

       
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            var category = _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
           
            return View( new CategoryUpdateVM()
            {
                Name= category.Name,    
                Desc= category.Desc,    
            });
          
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]// qiraqdan sorgulara cavab vermir inputun valuesi=undan istifade edir
        public IActionResult Update(int? id, CategoryUpdateVM categoryupdate)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var exist = _appDbContext.Categories.Any(c => c.Name.ToLower() == categoryupdate.Name.ToLower() && c.Id!=id
            
            );
            if (exist)
            {
                ModelState.AddModelError("Name", "Bu adli category movcuddur");

            }
            if (id == null) return NotFound();
            var category = _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
          
            return RedirectToAction();

        }

      

        }
}
