using System;
using System.Linq;
using DonateBlood.Services.ServiceInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using X.PagedList;

namespace DonateBlood.Controllers
{
    [Authorize]
    public class SearchDonorsController : Controller
    {

        private IUnitOfWork _unitOfWork;
        public SearchDonorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;

        }


        public IActionResult Index([FromQuery] string BloodTypes = null, string Region = null, int? page = null)
        {
            int pageSize = 3;
            int pageNumber = (page ?? 1);


            if (!String.IsNullOrWhiteSpace(Region))
            {
                return View(_unitOfWork.Donor.GetAllDonors().Where(x => x.Location.Contains(Region)).ToPagedList(pageNumber, pageSize));
            }
            else if (BloodTypes == "All" || String.IsNullOrWhiteSpace(BloodTypes))
            {
                return View(_unitOfWork.Donor.GetAllDonors().ToPagedList(pageNumber, pageSize));
            }
            else if (BloodTypes != "All")
            {
                return View(_unitOfWork.Donor.GetAllDonors().Where(x => x.BloodType == BloodTypes).ToPagedList(pageNumber, pageSize));

            }

            return View(_unitOfWork.Donor.GetAllDonors().ToPagedList(pageNumber, pageSize));
        }

        [HttpGet]
        public IActionResult DonorDetails(string userId){
        var donorDetails = _unitOfWork.Donor.GetUserById(userId);
        if(donorDetails == null){
            return NotFound();
        }
        return View("~/Views/SearchDonors/DonorDetails.cshtml",donorDetails);
        }

    }

   
}