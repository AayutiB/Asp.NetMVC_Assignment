using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/Greet/{name?}")]
        public IActionResult Greet(string name)
        {

            ViewBag.wish = "Hello " + name;
            return View();
        }

        public IActionResult GetData(int id)
        {

            ViewBag.message = "id=" + id;
            return View();
        }

        [Route("[controller]/[action]/{a?}/{b?}")]
        public IActionResult AddNumbers(int a,int b)
        {
            int result = a + b;
            ViewBag.result = result;
            return View();
        }

        public IActionResult ModelDemo()
        {
            Employees employees = new Employees { EmpId = 1, EmpName = "Aayuti", Salary = 30000 };
           // ViewBag.emp = employees;
            ViewData["emp"] = employees;
            return View();
        }

        public IActionResult EmployeeForm()
        {
           
            return View( new Employees());
        }


        public IActionResult DisplayEmployeesData(Employees employees)
        {
            return View(employees);
        }


    }
}
