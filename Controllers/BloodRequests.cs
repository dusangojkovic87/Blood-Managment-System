using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class BloodRequests:Controller
    {
        
    [HttpGet]
    public IActionResult Index(){
    return View();

    }
        
    }
}