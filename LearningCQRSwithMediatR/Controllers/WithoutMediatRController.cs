using LearningCQRSwithMediatR.Managers;
using LearningCQRSwithMediatR.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearningCQRSwithMediatR.Controllers
{

    public class WithoutMediatRController : Controller
    {

        private IUserManager _userManager;

        public WithoutMediatRController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userManager.GetAllUsers();
            return View(users);
        }

        [HttpGet]
        public IActionResult AddUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userManager.AddUser(user);
            return RedirectToAction("GetAllUsers");
        }

    }

}