using Employee_management_system.Database.Models;
using Employee_management_system.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Employee_management_system.Utilities;
using Employee_management_system.Database.Repositories;
using Employee_management_system.Database;
using System;
using Microsoft.EntityFrameworkCore;

namespace Employee_management_system.Controllers
{
    public class HomeController : Controller
    {
        private readonly EmployeerDbContext _dbContext;

        public HomeController()
        {
            _dbContext = new EmployeerDbContext();
        }
        [HttpGet]
        public IActionResult Index()
        {
            ViewModel viewModel = new ViewModel();

            var dbContext = new EmployeerDbContext();

            viewModel.employeer = dbContext.Employeers.ToList();

            //var employeerViewModels = viewModel.employeer.Select(p => new Employeer
            //{
            //    Name = p.Name,
            //    Surname = p.Surname,
            //    FatherName = p.FatherName,
            //    PINcode = p.PINcode,
            //    Email = p.Email,
            //    Photo = p.Photo,
            //    Departament = p.Departament,
            //    EmployeerCode = p.EmployeerCode,
            //    IsDeleted = p.IsDeleted
            //})
            //.ToList();

            //var result = View("~/Views/Home/Index.cshtml", employeerViewModels);


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
        [HttpGet]
        public IActionResult EditEmployee(string id)
        {
            EmployeerRepository employeerRepository = new EmployeerRepository();
            var employee = employeerRepository.GetByEmployeerCode(id);

            return View(employee);
        }
        [HttpPost]
        public IActionResult EditEmployee(Employeer editEmployee)
        {
            EmployeerRepository employeerRepository = new EmployeerRepository();
            var existingEmployee = employeerRepository.GetByEmployeerCode(editEmployee.EmployeerCode);

            existingEmployee.Name = editEmployee.Name;
            existingEmployee.Surname = editEmployee.Surname;
            existingEmployee.FatherName = editEmployee.FatherName;
            existingEmployee.Email = editEmployee.Email;
            existingEmployee.Photo = editEmployee.Photo;
            existingEmployee.Departament = editEmployee.Departament;
            existingEmployee.PINcode = editEmployee.PINcode;


            _dbContext.Employeers.Update(existingEmployee);
            _dbContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
