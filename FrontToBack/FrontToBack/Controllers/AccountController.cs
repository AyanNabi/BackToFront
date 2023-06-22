using FrontToBack.DAL;
using FrontToBack.Helper;
using FrontToBack.Models;
using FrontToBack.Services;
using FrontToBack.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> _signmanager;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;



        public AccountController(UserManager<AppUser> usermanager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = usermanager;
            _signmanager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser user = new AppUser();
            user.FullName = registerVM.Fullname;
            user.Email = registerVM.Email;
            user.UserName = registerVM.Username;
            IdentityResult result = await _userManager.CreateAsync(user, registerVM.Password);//startupdaki xetalari qaytaracaq. optionsda teyin etdiklerim ve defaultdakilar
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);



            }

            await _userManager.AddToRoleAsync(user, RoleEnums.Member.ToString());

            //arxada session isledir
            return RedirectToAction("Index", "Home");
            //return RedirectToAction("Index", "Home", new { area = "AdminArea" });

        }




        public async Task<IActionResult> Logout()
        {
            await _signmanager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Login()
        {
            return View();
        }




        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM, string returnURl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser user = await _userManager.FindByNameAsync(loginVM.UsernameOrEmail);
            if (user == null)
            {
                user = await _userManager.FindByEmailAsync(loginVM.UsernameOrEmail);




            }
            if (user == null)
            {
                ModelState.AddModelError("", "Username or email does not exist");
                return View();
            }

            var result = await _signmanager.PasswordSignInAsync(user, loginVM.UsernameOrEmail, loginVM.RememberMe, true);
            if (result.Succeeded)
            {
                ModelState.AddModelError("", "Username or email does not exist");
                return View();


            }
            if (returnURl!=null)
            {
                return RedirectToAction(returnURl);
            }

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Your Entry is blocked");
                return View();

                //_usermanager.F
            }
            await _signmanager.SignInAsync(user, loginVM.RememberMe);
            var userRoleList =await _userManager.GetRolesAsync(user);
            
            if (userRoleList.Contains(RoleEnums.Admin.ToString()))
            {
              return RedirectToAction("Index", "Dashboard", new {area= "adminArea"} );

            }
            //_usermanager.RemoveFromRoleAsync(user,)
            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> AddRole()
        {
           
            foreach (var item in Enum.GetValues(typeof(RoleEnums)))
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = item.ToString() });
            }
            return View();
        }


    }

}
