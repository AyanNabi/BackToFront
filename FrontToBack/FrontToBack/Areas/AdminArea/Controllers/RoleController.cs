using FrontToBack.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FrontToBack.Areas.AdminArea.Controllers
{

    [Area("AdminArea")]
    public class RoleController : Controller
    {

        readonly AppDbContext _appDbContext;
        readonly RoleManager<IdentityRole> _roleManager;

        public RoleController(AppDbContext appDbContext, RoleManager<IdentityRole> roleManager)
        {
            _appDbContext = appDbContext;
            _roleManager = roleManager;     
        }
        public IActionResult Index()
        {
           var roles= _roleManager.Roles.ToList();
            return View(roles);
        }
    }
}

