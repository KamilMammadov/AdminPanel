using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]

    public class HospitalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
