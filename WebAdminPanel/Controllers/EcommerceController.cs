using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    public class EcommerceController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ProductDetail()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }

    }
}
