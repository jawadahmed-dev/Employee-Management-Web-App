using DemoDotNetCore.Repositories;
using DemoDotNetCore.ViewModels;
using EMS.Models;
using EMS.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EMS.Controllers
{
	public class HomeController : Controller
	{
		public IEmployeeRepository _employeeRepository { get; }
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(IEmployeeRepository employeeRepository, IHostingEnvironment hostingEnvironment)
		{
			_employeeRepository = employeeRepository;
			_hostingEnvironment = hostingEnvironment;
		}

        public IActionResult Index()
        {

            return View(_employeeRepository.getAllEmployees());
        }

        // GET: HomeController/Details/id
        public ViewResult Details(int id)
        {

            var employee = _employeeRepository.GetEmployeeById(id);

            if (employee == null)
            {

                return View("EmployeeNotFound", id);
            }
            var viewModel = new HomeDetailsViewModel
            {
                Employee = new Models.Employee
                {
                    Name = employee.Name,
                    Email = employee.Email,
                    Id = employee.Id,
                    Department = employee.Department
                }
                ,
                PageTitle = "Employee Details"
            };

            return View(viewModel);
        }

        [HttpGet]
        public ViewResult Create()
        {

            return View();
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Employee employee = _employeeRepository.GetEmployeeById(id);
            var editEmployee = new EditEmployeeViewModel
            {
                Name = employee.Name,
                Email = employee.Email,
                Department = employee.Department,
                PhotoPath = employee.PhotoPath
            };
            return View(editEmployee);
        }

        [HttpPost]
        public IActionResult Edit(EditEmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {

                var employee = new Employee
                {
                    Id = model.Id,
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department,
                    PhotoPath = model.PhotoPath
                };

                var createdEmployee = _employeeRepository.UpdateEmployee(employee);
                return RedirectToAction("Details", new { id = createdEmployee.Id });

            }

            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateEmployeeViewModel model)
        {

            if (ModelState.IsValid)
            {

                string uniqueFileName = "";

                if (model.Photo != null)
                {
                    string uploadFolder = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                    string uploadPath = Path.Combine(uploadFolder, uniqueFileName);

                    using (var fileStream = new FileStream(uploadPath, FileMode.Create))
                    {
                        model.Photo.CopyTo(fileStream);
                    }

                }

                var newEmployee = new Employee
                {
                    Name = model.Name,
                    Email = model.Email,
                    Department = model.Department,
                    PhotoPath = uniqueFileName
                };

                var createdEmployee = _employeeRepository.CreateEmployee(newEmployee);
                return RedirectToAction("Details", new { id = createdEmployee.Id });

            }

            return View();

        }
    }
}
