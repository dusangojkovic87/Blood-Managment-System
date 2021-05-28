using System.Threading.Tasks;
using AutoMapper;
using DonateBlood.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class RegisterController : Controller
    {
        private UserManager<AplicationUser> _userManager;
        private SignInManager<AplicationUser> _signInManager;

        public RegisterController(SignInManager<AplicationUser> signInManager, UserManager<AplicationUser> userManager)
        {
            
            _signInManager = signInManager;
            _userManager = userManager;

        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Register(AplicationUser model)
        {
            if (ModelState.IsValid)
            {

                var userExist = await _userManager.FindByEmailAsync(model.Email);
                if (userExist != null)
                {
                    ModelState.AddModelError("Email", "User with this email exists");
                    return View("Index", model);
                }

                var user = model;
                user.UserName = model.Email;


                IdentityResult result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return Redirect("/Login");
                }
                else
                {
                    ModelState.AddModelError("User", "User registration failed");
                    return View("Index", model);
                }
            }

            return View("Index", model);
        }

    }
}