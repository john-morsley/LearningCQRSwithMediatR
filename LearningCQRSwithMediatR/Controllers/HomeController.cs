using Microsoft.AspNetCore.Mvc;

namespace LearningCQRSwithMediatR.Controllers
{

    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }

}