using System.Threading.Tasks;
using DonateBlood.Models;
using DonateBlood.Services.ServiceInterface;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DonateBlood.Controllers
{
    public class DeleteAccountController : Controller
    {
        private UserManager<AplicationUser> _userManager;
        private SignInManager<AplicationUser> _signInManager;
        private IUnitOfWork _unitOfWork;
        public DeleteAccountController(UserManager<AplicationUser> userManager, SignInManager<AplicationUser> signInManager, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _signInManager = signInManager;
            _userManager = userManager;
        }



        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);

                if (user == null)
                {
                    ModelState.AddModelError("Email", "User with this email not found!");
                }

                var passwordOk = await _userManager.CheckPasswordAsync(user, model.Password);

                if (!passwordOk)
                {
                    ModelState.AddModelError("Password", "incorect password!");
                    return View("Index", model);
                }

                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                {
                    _unitOfWork.Save();
                    await _signInManager.SignOutAsync();
                    return Redirect("/Home");
                }

                ModelState.AddModelError("Email", "Error user not deleted!");

                return View("Index", model);
            }


            return View("Index", model);
        }



    }
}