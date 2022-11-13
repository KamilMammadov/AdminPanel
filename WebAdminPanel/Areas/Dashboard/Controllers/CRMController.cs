using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CRMController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
