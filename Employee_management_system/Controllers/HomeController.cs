using Microsoft.AspNetCore.Mvc;

namespace Employee_management_system.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
    }
}
