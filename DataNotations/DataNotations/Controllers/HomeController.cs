using DataNotations.Models;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Index()
        {
           
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
