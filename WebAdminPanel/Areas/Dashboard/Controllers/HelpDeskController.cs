using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]

    public class HelpDeskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
