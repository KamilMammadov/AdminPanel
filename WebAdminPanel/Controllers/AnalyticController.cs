using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
	public class AnalyticController : Controller
	{
		public IActionResult Customers()
		{
			return View();
		}
        public IActionResult Reports()
        {
            return View();
        }
    }
}
