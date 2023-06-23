using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class UserController : Controller
    {
        private readonly SignInManager<AppUser> _signmanager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;



        public UserController(UserManager<AppUser> usermanager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = usermanager;
            _signmanager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index(string? name)
        {

            var users = name != null ? _userManager.Users.Where(u => u.FullName.ToLower().Contains(name.ToLower())).ToList() : _userManager.Users.ToList();

            _userManager.Users.ToList();
            return View(users);
        }

        public async Task<IActionResult> BlockOrActivate(string? id)
        {
            //var user = _userManager.Users.FirstOrDefault(u => u.Id == id);
            var user =await _userManager.FindByIdAsync(id);


            if (user != null)
            {
                user.IsBlocked = (!user.IsBlocked);
            }
            await _userManager.UpdateAsync(user);
            
          
            
            return RedirectToAction("index");
        }

        public async Task<IActionResult> Update(string? id)
        {
            AppUser user = await _userManager.FindByIdAsync(id);
            var userroles = await _userManager.GetRolesAsync(user);

            RoleVM roleVM = new RoleVM();
            roleVM.UserRoles=userroles;
            roleVM.Roles = _roleManager.Roles.ToList();
            roleVM.Fullname = user.FullName;
            roleVM.UserId = user.Id;
            return View(roleVM);
        }


        }
    }
