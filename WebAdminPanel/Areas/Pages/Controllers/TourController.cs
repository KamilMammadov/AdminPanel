using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Areas.Pages.Controllers
{
    [Area("Pages")]

    public class TourController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
