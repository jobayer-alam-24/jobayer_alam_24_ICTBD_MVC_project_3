using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using jobayer_alam_24_ICTBD_MVC_project_3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace jobayer_alam_24_ICTBD_MVC_project_3.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ILogger<StudentsController> _logger;

        public StudentsController(ILogger<StudentsController> logger)
        {
            _logger = logger;
        }

        public IActionResult Data()
        {
            Students student1 = new Students()
            {
                StudentsID = 1,
                Name = "Sheikh Jobayer Alam",
                Age = 14,
                PhoneNumber = "01903081188",
                Email = "jobayer@gmail.com",
                Address = "Dhaka, Bangladesh",
                Grade = 5.00f
            };

            return View(student1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}