using Microsoft.AspNetCore.Mvc;
using MVCDemoApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemoApp.Controllers
{
    public class AssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult RegistrationForm()
        {
            Registration rc = new Registration();

            return View(rc);
        }


        [HttpPost]
       // [ValidateAntiForgeryToken]
        public IActionResult DisplayForm(Registration data)
        {
            if (data !=null)
            {
                ViewBag.DefaultMessage = "Thank You "+data.Username;
                if (data.WillAttend == "Yes")
                {                    
                    ViewBag.Message = "Thank you for registration,we will be waiting for you   " ;
                }
                if (data.WillAttend == "No")
                {
                    ViewBag.Message = "Sorry to hear that you can't make it,but thanks for letting us know  ";
                }
            }
           // ViewBag.message = "Thank you " + Username  ;
            return View();
        }

    }
}
