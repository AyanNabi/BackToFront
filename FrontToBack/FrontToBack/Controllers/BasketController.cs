﻿using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
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
                products.Add(AddBasketVM(product));
            }
            else
            {
                existproduct.ProductCount++;

            }

            AppendToCookieStorage("Basket", 10, products);


            return RedirectToAction("Index","Home");

         
        }

        public IActionResult ShowBasket()
        {
            //string result= Request.Cookies["p515"];
            var basket = Request.Cookies["Basket"];
            List<BasketVM> products;
            if (basket == null)
            {
                products = new List<BasketVM>();
            }
            else
            {

                products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
                foreach (var item in products)
                {
                    Product exist = _appDbContext.Products
                        .Include(p=>p.ProductImages)
                        .FirstOrDefault(p => p.Id == item.Id);
                    if (exist!=null)
                    {
                        item.Name = exist.Name;
                        item.Price= exist.Price;
                        item.ProductImage = exist.ProductImages.FirstOrDefault().ImageUrl;
                        
                    }
                }
            }
            return View(products);

        }
      


        public BasketVM AddBasketVM(Product product)
        {
            BasketVM basketvm = new BasketVM
            {
                Id = product.Id,
                ProductCount = 1,
            };
            return basketvm;


        }

        public void AppendToCookieStorage(string cookieName, int minute, List<BasketVM> products)
        {
            var result = JsonConvert.SerializeObject(products);

            Response.Cookies.Append(cookieName, result, new CookieOptions()
            {
                MaxAge = System.TimeSpan.FromMinutes(minute)
            });
        }

        public IActionResult RemoveProduct(int? id)
        {
            DecreaseOrIncreaseProduct("remove", id);
            return RedirectToAction("ShowBasket", "Basket");
        }


        public IActionResult DecreaseProduct(int? id)
        {
            DecreaseOrIncreaseProduct("decrease", id);
            return RedirectToAction("ShowBasket", "Basket");
        }


        public IActionResult AddProduct(int? id)
        {
            DecreaseOrIncreaseProduct("add", id);
            return RedirectToAction("ShowBasket", "Basket");
        }


        public List<BasketVM> GetProductList(string cookieName)
        {
            var basket = Request.Cookies[cookieName];
            List<BasketVM> products;
            if (basket == null)
            {
                products = new List<BasketVM>();
            }
            else
            {

                products = JsonConvert.DeserializeObject<List<BasketVM>>(basket);
            }
            return products;

        }

        public void DecreaseOrIncreaseProduct(string option, int?id)
        {
                List<BasketVM> products = GetProductList("Basket");
                var exist = products.Find(p => p.Id == id);


            if (option == "add")
            {
                exist.ProductCount++;

                AppendToCookieStorage("Basket", 10, products);

            }
            else if(option=="decrease")
            {
                if (exist.ProductCount == 1)
                {
                    products.Remove(exist);
                }
                else
                {
                    exist.ProductCount--;
                }

            }
            else if (option=="remove")
            {
                products.Remove(exist);
            }
            AppendToCookieStorage("Basket", 10, products);
        }



    }
}


