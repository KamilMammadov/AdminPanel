using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    public class EcommerceController : Controller
    {
        public IActionResult Products()
        {
            return View();
        }
    }
}
