using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class CryptoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
