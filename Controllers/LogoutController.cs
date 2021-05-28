using System.Threading.Tasks;
using DonateBlood.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class LogoutController : Controller
    {
        private  SignInManager<AplicationUser> _signInManager;
        public LogoutController(SignInManager<AplicationUser> signInManager)
        {
           _signInManager = signInManager;

        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Login");
        }

    }
}