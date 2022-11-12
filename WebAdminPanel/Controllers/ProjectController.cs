using Microsoft.AspNetCore.Mvc;

namespace WebAdminPanel.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Clients()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult Project()
        {
            return View();
        }

        public IActionResult Task()
        {
            return View();
        }

        public IActionResult KanbanBoard()
        {
            return View();
        }
        public IActionResult Chat()
        {
            return View();
        }
        public IActionResult Users()
        {
            return View();
        }
        public IActionResult ProjectCreate()
        {
            return View();
        }
    }
}
