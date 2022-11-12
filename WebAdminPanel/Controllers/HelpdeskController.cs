using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    public class HelpdeskController : Controller
    {
        public IActionResult Ticket()
        {
            return View();
        }
        public IActionResult Reports()
        {
            return View();
        }
        public IActionResult Agents()
        {
            return View();
        }
    }
}
