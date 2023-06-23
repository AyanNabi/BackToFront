using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Areas.AdminArea.Controllers
{

    [Area("AdminArea")]
    public class RoleController : Controller
    {

        readonly AppDbContext _appDbContext;
        readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleController(AppDbContext appDbContext, RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            _appDbContext = appDbContext;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {

            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Create(string roleName)
        {
            if (string.IsNullOrEmpty(roleName))
            {
                return BadRequest();
            }

            await _roleManager.CreateAsync(new IdentityRole { Name = roleName });
            //var roles = _roleManager.Roles.ToList();
            return RedirectToAction("index");
        }
        public async Task<IActionResult> Delete(string id)
        {
          var role=  await _roleManager.FindByIdAsync(id);
                
            if (role == null) return BadRequest();
            await _roleManager.DeleteAsync(role);   

            return RedirectToAction("index");

        }

        public async Task<IActionResult> Update(string? id)
        {
            var user = await _userManager.FindByIdAsync(id);

            var userRoles = await _userManager.GetRolesAsync(user);
            var roles = _roleManager.Roles.ToList();
            return View(
                new RoleUpdateVM()
                {
                    appUser = user,
                    UserRoles = userRoles,
                    Roles = roles

                });



        }

        [HttpPost]
        public async Task<IActionResult> Update(string? userId, List<string>newRoles)
        {
            var user= await _userManager.FindByIdAsync(userId);
            if (user == null) return BadRequest();
            var userroles = await _userManager.GetRolesAsync(user);
            await _userManager.RemoveFromRolesAsync(user,userroles);
            await _userManager.AddToRolesAsync(user,newRoles);
            return RedirectToAction("index", "user");   
        
        }





     }
}

