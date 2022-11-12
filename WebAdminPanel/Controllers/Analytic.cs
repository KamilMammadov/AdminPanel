using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
	public class Analytic : Controller
	{
		public IActionResult Customers()
		{
			return View();
		}
	}
}
