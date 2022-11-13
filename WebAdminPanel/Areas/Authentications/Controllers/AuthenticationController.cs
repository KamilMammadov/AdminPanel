using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Areas.Authentications.Controllers
{
        [Area("Authentications")]
    public class AuthenticationController : Controller
    {
        public IActionResult LogIn()
        {
            return View();
        }
        public IActionResult LogInAlt()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
