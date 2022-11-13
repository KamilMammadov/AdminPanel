using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Areas.Apps.Controllers
{
    [Area("apps")]
    
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
