using System;
using System.Linq;
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


        public IActionResult Index([FromQuery] string BloodTypes = null, string Region = null)
        {
            var donorsVm = new DonorsViewModel();

            if (!String.IsNullOrWhiteSpace(Region))
            {
                donorsVm.Donors = _unitOfWork.Donor.GetAllDonors().Where(x => x.Location.Contains(Region));
                return View(donorsVm);
            }
            else if (BloodTypes == "All" || String.IsNullOrWhiteSpace(BloodTypes))
            {
                donorsVm.Donors = _unitOfWork.Donor.GetAllDonors();
                return View(donorsVm);
            }
            else if (BloodTypes != "All")
            {
                donorsVm.Donors = _unitOfWork.Donor.GetAllDonors().Where(x => x.BloodType == BloodTypes);
                return View(donorsVm);

            }


            donorsVm.Donors = _unitOfWork.Donor.GetAllDonors();
            return View(donorsVm);
        }



    }
}