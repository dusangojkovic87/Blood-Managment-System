using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    [Authorize]
    public class MyProfileController:Controller
    {
        public IActionResult Index(){
            
        return View();
        }
        
    }
}