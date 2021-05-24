using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class LoginController:Controller
    {
        public IActionResult Index(){
            return View();
        }
        
    }
}