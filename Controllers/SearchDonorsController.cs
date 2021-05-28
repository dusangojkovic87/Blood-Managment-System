using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var donors = _unitOfWork.Donor.GetAllDonors();
            return View(donors);
        }
    }
}