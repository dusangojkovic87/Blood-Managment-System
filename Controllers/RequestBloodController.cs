using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class RequestBloodController:Controller
    {

    [HttpGet]
    public IActionResult Index(){
    return View();
    }
        
    }
}