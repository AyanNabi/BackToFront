using InMemoryDatabase.DAL.Interfaces;
using InMemoryDatabase.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InMemoryDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : Controller
    {
        readonly IAuthorRepository _authorRepository;
        public AuthorController(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        [HttpGet]
        public ActionResult<List<Author>> Get()
        {
            return Ok(_authorRepository.GetAuthors());
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
