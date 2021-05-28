using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using DonateBlood.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class LoginController : Controller
    {
        private UserManager<AplicationUser> _userManager;
        private SignInManager<AplicationUser> _signInManager;
        public LoginController(UserManager<AplicationUser> userManager, SignInManager<AplicationUser> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError("User", "No user with this email,register first!");
                    return View("Index", model);
                }

                var result = await _signInManager.PasswordSignInAsync(user,model.Password,false,false);
                if(!result.Succeeded){
                   ModelState.AddModelError("Password","Incorect Password!");
                   return View("Index",model);
                }

                return Redirect("/Home");

            }

            return View("Index", model);
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Login");

        }
    }


}