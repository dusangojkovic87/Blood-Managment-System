using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class SearchDonorsController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public SearchDonorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }
        public IActionResult Index()
        {
            var donorsVm = new DonorsViewModel();
            donorsVm.Donors = _unitOfWork.Donor.GetAllDonors();
            return View(donorsVm);
        }
    }
}