using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Areas.Pages.Controllers
{
    [Area("Pages")]

    public class PricingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
