using DonateBlood.Services.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class BloodRequestsController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public BloodRequestsController(IUnitOfWork unitOfWork)
        {
           _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
        var bloodRequests = _unitOfWork.BloodRequest.getBloodRequests();
        return View("Index",bloodRequests);
        }

    }
}