using System.Threading.Tasks;
using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class RequestBloodController : Controller
    {
        private IUnitOfWork _unitOfWork;
        private  UserManager<AplicationUser> _userManager;
        public RequestBloodController(IUnitOfWork unitOfWork, UserManager<AplicationUser> userManager)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;

        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendRequest(BloodRequest model)
        {

            if (ModelState.IsValid)
            {
                var userName = HttpContext.User.Identity.Name;
                var user = await _userManager.FindByEmailAsync(userName);
                var request = new BloodRequest{
                    BloodType = model.BloodType,
                    DonateLocation = model.DonateLocation,
                    BloodReqDesc = model.BloodReqDesc,
                    AplicationUserId = user.Id

                };

                _unitOfWork.BloodRequest.addBloodRequest(request);
                _unitOfWork.Save();
                return Redirect("/BloodRequests");


            }

            return View("Index", model);
        }


    }

}
