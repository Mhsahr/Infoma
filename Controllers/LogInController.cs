using Infoma.Models;
using Microsoft.AspNetCore.Mvc;

namespace Infoma.Controllers
{
    public class LogInController : Controller
    { 
        private readonly ILogger<LogInController> _logger;


    public LogInController(ILogger<LogInController> logger)
    {
        _logger = logger;

    }

        public IActionResult SignUp()
        {
            return View();
        }
    
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Type()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Type([FromForm] User person)
        {
            return RedirectToAction ("SignUp", "LogIn");
        }
    }
}
