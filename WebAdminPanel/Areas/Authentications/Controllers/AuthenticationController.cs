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
        public IActionResult RegisterAlt()
        {
            return View();
        }
        public IActionResult RePassword()
        {
            return View();
        }
        public IActionResult RePasswordAlt()
        {
            return View();
        }
        public IActionResult LockScreen()
        {
            return View();
        }
        public IActionResult LockScreenAlt()
        {
            return View();
        }
        public IActionResult Error404()
        {
            return View();
        }
        public IActionResult Error404Alt()
        {
            return View();
        }
        public IActionResult Error500()
        {
            return View();
        }
        public IActionResult Error500Alt()
        {
            return View();
        }
    }
}
