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
    
        public IActionResult LogIn()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
    }
}
