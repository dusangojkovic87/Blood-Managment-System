using DonateBlood.Services.ServiceInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace DonateBlood.Controllers
{
    [Authorize]
    public class BloodRequestsController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public BloodRequestsController(IUnitOfWork unitOfWork)
        {
           _unitOfWork = unitOfWork;

        }
        public IActionResult Index([FromQuery]int? page = null)
        {

        int pageSize = 3;
        int pageNumber = (page ?? 1);

        var bloodRequests = _unitOfWork.BloodRequest.getBloodRequests();
        return View("Index",bloodRequests.ToPagedList(pageNumber,pageSize));
        }

        public IActionResult BloodRequestDetails(int Id){
            if(!ModelState.IsValid){
                return View("Index");
            }

        var bloodrequest = _unitOfWork.BloodRequest.getBloodRequestById(Id);
        return View("~/Views/BloodRequests/BloodRequestDetails.cshtml",bloodrequest);

        }

    }
}