using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
