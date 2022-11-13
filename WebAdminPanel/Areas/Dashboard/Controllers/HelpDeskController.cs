using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Areas.Dashboard.Controllers
{
    public class HelpDeskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
