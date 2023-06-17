using FrontToBack.DAL;
using FrontToBack.Helper;
using FrontToBack.Models;
using FrontToBack.Services;
using FrontToBack.ViewModels.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class AccountController : Controller
    {
        readonly UserManager<AppUser> _usermanager;
        readonly SignInManager<AppUser> _signInManager;
        readonly RoleManager<AppUser> _roleManager;




        public AccountController(UserManager<AppUser> usermanager, SignInManager<AppUser> signInManager, RoleManager<AppUser> roleManager)
        {
            _usermanager = usermanager;
            _signInManager = signInManager;
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
            IdentityResult result = await _usermanager.CreateAsync(user, registerVM.Password);//startupdaki xetalari qaytaracaq. optionsda teyin etdiklerim ve defaultdakilar
            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
                return View(registerVM);



            }

            await _usermanager.AddToRoleAsync(user, RoleEnums.Member.ToString());

            //arxada session isledir
            return RedirectToAction("Index", "Home");
            //return RedirectToAction("Index", "Home", new { area = "AdminArea" });

        }




        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        public IActionResult Login()
        {
            return View();
        }




        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser user = await _usermanager.FindByNameAsync(loginVM.UsernameOrEmail);
            if (user == null)
            {
                user = await _usermanager.FindByEmailAsync(loginVM.UsernameOrEmail);




            }
            if (user == null)
            {
                ModelState.AddModelError("", "Username or email does not exist");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user, loginVM.UsernameOrEmail, loginVM.RememberMe, true);
            if (result.Succeeded)
            {
                ModelState.AddModelError("", "Username or email does not exist");
                return View();


            }

            if (result.IsLockedOut)
            {
                ModelState.AddModelError("", "Your Entry is blocked");
                return View();


            }
            await _signInManager.SignInAsync(user, loginVM.RememberMe);


            return RedirectToAction("Index", "Home");
        }


        public async Task<IActionResult> AddRole()
        {
            foreach (var item in Enum.GetValues(typeof(RoleEnums)))
            {
            await _roleManager.CreateAsync(new IdentityRole { Name=item.ToString()});

            }

            

            return View();
        }


    }

    }
