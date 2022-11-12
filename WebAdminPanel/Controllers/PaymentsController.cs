using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    public class PaymentsController : Controller
    {
        public IActionResult AllPayments()
        {
            return View();
        }
        public IActionResult Invoice()
        {
            return View();
        }
        public IActionResult Cashless()
        {
            return View();
        }

    }
}
