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
    public class CoursesController : Controller
    {
        private readonly ILogger<CoursesController> _logger;

        public CoursesController(ILogger<CoursesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Data()
        {
            Courses course = new Courses()
            {
                CourseID = 1,
                Name = "Spoken English",
                InstructorName = "Munzeeren Shahid",
                Price = 1200,
                TotalEnrolledStudents = 4000,
                CourseDuration = "5 Months"
            };

            return View(course);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}