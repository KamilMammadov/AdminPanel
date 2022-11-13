using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Inbox()
        {
            return View();
        }
        public IActionResult ReadEmail()
        {
            return View();
        }
    }
}
