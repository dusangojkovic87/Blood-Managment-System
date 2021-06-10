using System.Threading.Tasks;
using AutoMapper;
using DonateBlood.Helpers;
using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    [Authorize]
    public class MyProfileController : Controller
    {
        private UserManager<AplicationUser> _userManager;
        private IMapper _mapper;
        private IUnitOfWork _unitOfWork;

        private  IWebHostEnvironment _env;

        public MyProfileController(UserManager<AplicationUser> userManager, IMapper mapper, IUnitOfWork unitOfWork, IWebHostEnvironment env)
        {
            _env = env;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _userManager = userManager;

        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpGet]
        public async Task<IActionResult> EditProfile()
        {
            var userDetails = await _userManager.GetUserAsync(HttpContext.User);
            if (userDetails == null)
            {
                return NotFound();
            }
            ViewBag.SuccesUpdate = false;

            return View("~/Views/MyProfile/EditProfile.cshtml", userDetails);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(AplicationUser model)
        {
            if (!ModelState.IsValid)
            {
                return View("~/Views/MyProfile/EditProfile.cshtml", model);

            }
            var userFromDb = await _userManager.FindByIdAsync(model.Id);
            userFromDb.Name = model.Name;
            userFromDb.Surname = model.Surname;
            userFromDb.Email = model.Email;
            userFromDb.Location = model.Location;
            userFromDb.Phone = model.Phone;
            userFromDb.Password = model.Password;


            var result = await _userManager.UpdateAsync(userFromDb);
            if (!result.Succeeded)
            {
                ModelState.AddModelError("User", "Error,user data not updated!");
                return View("~/Views/MyProfile/EditProfile.cshtml", userFromDb);

            }

            return RedirectToAction("Index");



        }

        [HttpGet]
        public async Task<IActionResult> ChangeImage()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (user == null)
            {
                return NotFound();
            }
            return View("~/Views/MyProfile/ChangeImage.cshtml",user);

        }

        [HttpPost]
        public async Task<IActionResult> ChangeImage(IFormFile image)
        {

            if (image != null)
            {
                var root = _env.WebRootPath;
                var user = await _userManager.GetUserAsync(HttpContext.User);
                var imagePath = Uploader.UploadProfileImage(image, root);
                user.ProfileImg = imagePath;
                _unitOfWork.Donor.SaveProfileImage(user);
                _unitOfWork.Save();
                return Redirect("Index");

            }
            else
            {
                var user = await _userManager.GetUserAsync(HttpContext.User);
                ViewBag.SelectImage = "Please select image!";
                return View("~/Views/MyProfile/ChangeImage.cshtml",user);

            }
    
        }
        

    }
}