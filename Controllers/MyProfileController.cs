using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class MyProfileController:Controller
    {
        public IActionResult Index(){
            
        return View();
        }
        
    }
}