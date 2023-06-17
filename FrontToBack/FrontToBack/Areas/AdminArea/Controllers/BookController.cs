using FrontToBack.DAL;
using FrontToBack.Models.Practice;
using FrontToBack.ViewModels.AdminVM.Book;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FrontToBack.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class BookController : Controller
    {
       
        readonly AppDbContext _appDbContext;
        public BookController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
          var data=  _appDbContext.Books
                .Include(b => b.BookGenres)
                .ThenInclude(bg => bg.Genre)
                .ToList();

            return View(data);
        }
        public IActionResult Create()
        {
            ViewBag.Genres = new SelectList(_appDbContext.Genres.ToList(), "Id", "Name");
;            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateBookVM createBookVM)
        {
            ViewBag.Genres = new SelectList(_appDbContext.Genres.ToList(), "Id", "Name");
            Book book = new Book();
            book.Name = createBookVM.Name;
            List<BookGenre> bookgenres = new List<BookGenre>();


            foreach (var item in createBookVM.GenreIds)
            {
                BookGenre bookGenre = new BookGenre();
                bookGenre.BookId = book.Id;
                bookGenre.GenreId = item;
                bookgenres.Add(bookGenre);  

            }
            book.BookGenres = bookgenres;
            _appDbContext.Books.Add(book);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
