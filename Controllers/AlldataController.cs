using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using jobayer_alam_24_ICTBD_MVC_project_3.Models;
using jobayer_alam_24_ICTBD_MVC_project_3.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace jobayer_alam_24_ICTBD_MVC_project_3.Controllers
{
    public class AlldataController : Controller
    {
        private readonly ILogger<AlldataController> _logger;
        private Students student;

        public AlldataController(ILogger<AlldataController> logger)
        {
            _logger = logger;
        }

        public object Student { get; private set; }
        public Courses Course { get; private set; }
        public Books Book { get; private set; }

        public IActionResult Data()
        {
            //Student Object
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
            //Course Object
            Courses course1 = new Courses()
            {
                CourseID = 1,
                Name = "Spoken English",
                InstructorName = "Munzeeren Shahid",
                Price = 1200,
                TotalEnrolledStudents = 4000,
                CourseDuration = "5 Months"
            };
            //Book Objec
            Books book1 = new Books()
            {
                BookID = 1,
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                Genre = "Fiction",
                Publisher = "J.B. Lippincott & Co.",
                ISBN = "978-0-06-112008-4"
            };
            //View Models - Multiple Views
            Alldata alldata = new Alldata();
            {
                Student = student1;
                Course = course1;
                Book = book1;
            };

            return View(alldata);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}