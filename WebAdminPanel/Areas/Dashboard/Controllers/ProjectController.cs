using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
