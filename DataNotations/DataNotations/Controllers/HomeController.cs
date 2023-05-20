using DataNotations.DAL;
using DataNotations.Models;
using DataNotations.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;

namespace DataNotations.Controllers
{
    public class HomeController : Controller
    {
        //public HomeController()
        //{
        //    Group group = new Group()
        //    {
        //        Id = 1,
        //        Name = "P515",
        //        MaxSize = 10


        //    };
        //}
        readonly AppDbContext _appDbContext;
        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
        //    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
        //    public class IsEmptyAttribute : ValidationAttribute
        //{
        //    public override bool IsValid(object value)
        //    {
        //        var inputValue = value as string;
        //        return !string.IsNullOrEmpty(inputValue);
        //    }
        //}
        //HomeVM homevm = new HomeVM();
        //    homevm.Students = _appDbContext.Students;

           
            //Student student1 = new Student()
            //{
            //    Id=1,
            //    Name="Ayan",
            //    Age=20,
            //    GroupId=1,
            //    Email="ayannebizade431@gmail.com",
            //    UserNameGoogle="AyanNabi",
            //    UserPasswordGoogle="aaa.",
            //    ConfirmPasswordGoogle= "aaa.",
            //    CardNumber ="1234212121"

            //};


            return View();
        }
    }
}
