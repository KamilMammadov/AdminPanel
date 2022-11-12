using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    public class CryptoController : Controller
    {
        public IActionResult Exchange()
        {
            return View();
        }

        public IActionResult Wallet()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }
        public IActionResult Ico()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }
    }
}
