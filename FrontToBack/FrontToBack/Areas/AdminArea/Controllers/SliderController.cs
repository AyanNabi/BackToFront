using FrontToBack.DAL;
using FrontToBack.Helper;
using FrontToBack.Models;
using FrontToBack.ViewModels.AdminVM.Category;
using FrontToBack.ViewModels.AdminVM.Slider;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;

namespace FrontToBack.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class SliderController : Controller

    {
        readonly AppDbContext _appDbContext;
        readonly IWebHostEnvironment _webenvironment;

        public SliderController(AppDbContext appDbContext, IWebHostEnvironment webenvironment)
        {
            _appDbContext = appDbContext;
            _webenvironment = webenvironment;
        }
        public IActionResult Index()
        {

            return View(_appDbContext.BlogSliders.ToList());
        }
        public IActionResult Delete(int?id )
        {

            if (id == null) return NotFound();
            var slider = _appDbContext.BlogSliders
                
                .FirstOrDefault(c => c.Id == id);
            if (slider == null) return NotFound();
          
            string path = Path.Combine(_webenvironment.WebRootPath, "img", slider.ImageUrl);
            HelperServices.DeleteFile(path);
            _appDbContext.BlogSliders.Remove(slider);
            _appDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Detail(int? id)
        {
            if (id == null) return NotFound();
            var category = _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return NotFound();
            return View(category);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        //[AutoValidateAntiforgeryToken]

        public IActionResult Create( SliderCreateVM sliderCreateVM)
        {
            foreach (var photo in sliderCreateVM.Photos)
            {
                if (photo == null)
                {
                    ModelState.AddModelError("Photo", "Photo is required");
                    return View();
                }

                if (!photo.CheckFileType())
                {

                    ModelState.AddModelError("Photo", "Duzgun sec");
                    return View();

                }
                if (!photo.CheckFileSize(1000))
                {

                    ModelState.AddModelError("Photo", "Boyukdur");
                    return View();

                }

                BlogSlider slider = new BlogSlider();
                slider.ImageUrl = photo.SaveImage(_webenvironment, "img");
                //slider.Photo = filename;
                _appDbContext.BlogSliders.Add(slider);
                _appDbContext.SaveChanges();
            }

          

            return RedirectToAction("Index");
        }


 
        

        //public IActionResult Update(int id)
        //{
        //    if (id == null) return NotFound();
        //    var category = _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
        //    if (category == null) return NotFound();

        //    return View(new CategoryUpdateVM()
        //    {
        //        Name = category.Name,
        //        Desc = category.Desc,
        //    });
        //}

        //public IActionResult Update(int? id, SliderUpdateVM categoryupdate)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    var exist = _appDbContext.Categories.Any(c => c.Name.ToLower() == categoryupdate.Name.ToLower() && c.Id != id

        //    );
        //    if (exist)
        //    {
        //        ModelState.AddModelError("Name", "Bu adli category movcuddur");

        //    }
        //    if (id == null) return NotFound();
        //    var category = _appDbContext.Categories.FirstOrDefault(c => c.Id == id);
        //    if (category == null) return NotFound();

        //    return RedirectToAction("Update");
        //}

        }
    }
