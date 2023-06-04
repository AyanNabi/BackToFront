using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FrontToBack.Controllers
{
    public class BasketController : Controller
    {

        readonly AppDbContext _appDbContext;
        public BasketController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult AddToBasket(int?id)
        {
            //HttpContext.Session.SetString("P515", "15");

            //return View(HttpContext.Session.GetString("p515"));
            ////Response.Cookies.Append("p515", "15", new CookieOptions()
            ////{
            ////    MaxAge = System.TimeSpan.FromMinutes(10)
            ////});
            //return Content("Set olundu");

            if (id == null) return NotFound();
            var product = _appDbContext.Products
                .Include(p => p.ProductImages)
                .FirstOrDefault(p=>p.Id==id);
            //.Include(p=>p.ProductImages)
            //.ToList();
            var basket = Request.Cookies["Basket"];
            if (product == null) return NotFound();

            List<BasketVM> products;
            if (basket == null)
            {
                products = new List<BasketVM>();
            }
            else
            {

                products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }

            var existproduct = products.Find(p => p.Id == product.Id);
            if (existproduct == null)
            {
                BasketVM basketvm = new BasketVM
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    ProductCount = 1,
                    ProductImage = product.ProductImages.FirstOrDefault().ImageUrl
                };

                products.Add(basketvm);
            }
            else
            {
                existproduct.ProductCount++;

            }


            var result = JsonConvert.SerializeObject(products);
            Response.Cookies.Append("Basket", result, new CookieOptions()
            {
                MaxAge = System.TimeSpan.FromMinutes(10)
            });

           



            return Content("Set oldu");
        }


        public IActionResult ShowBasket()
        {
            //string result= Request.Cookies["p515"];
            var result = Request.Cookies["Basket"];
            var products = JsonConvert.DeserializeObject<List<BasketVM>>(result);
            if (result==null)
            {

                products= new List<BasketVM>();
            }
            else
            { 



            }
        
            return View(products);

        }



    }
}
