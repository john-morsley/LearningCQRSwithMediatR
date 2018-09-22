using LearningCQRSwithMediatR.Commands;
using LearningCQRSwithMediatR.Models;
using LearningCQRSwithMediatR.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LearningCQRSwithMediatR.Controllers
{

    public class WithMediatRController : Controller
    {

        private IMediator _mediator;

        public WithMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var query = new GetAllUsersQuery();
            var users = _mediator.Send(query).Result;
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
            var command = new AddUserCommand(user.FirstName, user.LastName);
            _mediator.Send(command);
            return RedirectToAction("GetAllUsers");
        }

    }

}