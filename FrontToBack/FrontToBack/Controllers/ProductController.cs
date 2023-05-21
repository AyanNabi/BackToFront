using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FrontToBack.Controllers
{

    public class ProductController : Controller
    {
        readonly AppDbContext _appDbContext;
        public ProductController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            var query = _appDbContext.Products.AsQueryable();

            var products = query
                .Include(p => p.ProductImages)
                .Include(p => p.category)
                .Take(2)
                .ToList();
            ViewBag.ProductsCount = _appDbContext.Products.Count();

            return View(products);
        }

        public IActionResult LoadMore(int skip)
        {
            //var products=  _appDbContext.Products.Include(p => p.category).Include(p => p.ProductImages).ToList();
            //List<LoadMoreVM> list = new List<LoadMoreVM>();
            //foreach (var item in products)
            //{
            //  LoadMoreVM loadvm = new LoadMoreVM();
            //    loadvm.Id = item.Id;
            //    loadvm.Name = item.Name;
            //    loadvm.Price = item.Price;
            //     loadvm.ImageUrl = item.ProductImages.FirstOrDefault(p => p.IsMainImage).ImageUrl;
            //   loadvm.CategoryName= item.category.Name;
            //    list.Add(loadvm);



            //}
            //var loadmore = _appDbContext.Products
            //    //.Include(p => p.category)
            //    //.Include(p => p.ProductImages)//yazmasan gorur
            //    .Select(pr => new LoadMoreVM {
            //       Id=pr.Id,
            //       Name=pr.Name,    
            //       Price=pr.Price,  
            //       ImageUrl=pr.ProductImages.FirstOrDefault(p=>p.IsMainImage).ImageUrl,
            //       CategoryName=pr.category.Name

            //    })

            //    .ToList();


            //return Json(loadmore);
            var products = _appDbContext.Products
                .Include(p => p.category)
                .Include(p => p.ProductImages)
                .Skip(skip)
                .Take(2)
                .ToList();
           
            return PartialView("_LoadMorePartial", products );
        }


        public IActionResult Search(string searchletter)
        {
            var products = _appDbContext.Products
                .Where(p => p.Name.ToLower()
                .Contains(searchletter.ToLower()))
                .Take(3)
                .OrderByDescending(p=>p.Id)
                .ToList();

            return PartialView("_SearchPartial", products);

        }
    }
}
