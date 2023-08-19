using Employee_management_system.Database.Models;
using Employee_management_system.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Employee_management_system.Utilities;

namespace Employee_management_system.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(string name, string surname, string fatherName, string pinCode, string email, string photo, string department)
        {
            ViewModel viewModel = new ViewModel();
            var code = viewModel.stringUtility.GetEmployeeCode();

             var employeer = new Employeers(name,surname,fatherName,pinCode,email,photo,department, code, false);
             viewModel.employeer.Add(employeer);

            return View();
        }
    }
}
