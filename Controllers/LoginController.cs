using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class LoginController:Controller
    {
        [HttpGet]
        public IActionResult Index(){
        return View();
        }

        
        
    }
}