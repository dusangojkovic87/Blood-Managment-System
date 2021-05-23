using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class SignInController:Controller
    {

        public IActionResult Index(){
            return View();
        }      
    }
}