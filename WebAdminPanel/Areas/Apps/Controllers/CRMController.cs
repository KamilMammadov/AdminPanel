using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    [Area("apps")]
    public class CRMController : Controller
    {
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Opportunities()
        {
            return View();
        }
        public IActionResult Leads()
        {
            return View();
        }

        public IActionResult Customers()
        {
            return View();
        }
    }
}
