using Employee_management_system.Database.Models;
using Employee_management_system.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Employee_management_system.Utilities;
using Employee_management_system.Database.Repositories;
using Employee_management_system.Database;

namespace Employee_management_system.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewModel viewModel = new ViewModel();

            var dbContext = new EmployeerDbContext();
            viewModel.employeer = dbContext.Employeers.ToList();

            

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
            EmployeerRepository employeerRepository = new EmployeerRepository();
            ViewModel viewModel = new ViewModel();
            var code = viewModel.stringUtility.GetEmployeeCode();

             var employeer = new Employeer(name,surname,fatherName,pinCode,email,photo,department, code, false);
             employeerRepository.Insert(employeer);

            return View();
        }
    }
}
