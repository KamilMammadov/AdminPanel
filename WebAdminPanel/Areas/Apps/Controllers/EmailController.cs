using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
        [Area("apps")]
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
