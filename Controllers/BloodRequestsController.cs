using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class BloodRequestsController:Controller
    {
        public IActionResult Index(){
        return View();
        }
        
    }
}