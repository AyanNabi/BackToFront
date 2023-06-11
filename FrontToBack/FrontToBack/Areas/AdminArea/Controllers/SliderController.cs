using FrontToBack.DAL;
using FrontToBack.Helper;
using FrontToBack.Models;
using FrontToBack.ViewModels.AdminVM.Slider;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Constraints;
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
            SliderCreateVM slider = new SliderCreateVM();
            string path = Path.Combine(_webenvironment.WebRootPath, "img", slider.Photo.FileName);
            if (System.IO.File.Exists(""))
            {
                System.IO.File.Delete(path);
            }
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Create( SliderCreateVM sliderCreateVM)
        {
            if (sliderCreateVM.Photo==null)
            {
                ModelState.AddModelError("Photo", "Photo is required");
                return View();


            }
           
            if (sliderCreateVM.Photo.CheckFileType() )
            {

                ModelState.AddModelError("Photo", "Duzgun sec");
                return View();

            }
            if (sliderCreateVM.Photo.Length>1000)
            {

                ModelState.AddModelError("Photo", "Boyukdur");
                return View();

            }
            SliderImage sliderImage = new SliderImage();
            sliderImage.ImageUrl = "";
            _appDbContext.SliderImages.Add(sliderImage);
            _appDbContext.SaveChanges();



            var filename = Guid.NewGuid() + sliderCreateVM.Photo.FileName;
            var path = Path.Combine(_webenvironment.WebRootPath + "img" + sliderCreateVM.Photo.FileName);
            BlogSlider slider = new BlogSlider();
            //slider.Photo = filename;
            _appDbContext.BlogSliders.Add(slider);
            _appDbContext.SaveChanges();

            using (FileStream stream= new FileStream(path,FileMode.CreateNew))
            {
                sliderCreateVM.Photo.CopyTo(stream);    
            }


            return RedirectToAction("Index");
        }

 
        

        public IActionResult Update()
        {
            return View();
        }
    }
}
