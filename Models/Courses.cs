using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobayer_alam_24_ICTBD_MVC_project_3.Models
{
    public class Courses
    {
        public int CourseID { get; set;}
        public string Name { get; set;}
        public string InstructorName { get; set;}
        public float Price { get; set;}
        public int TotalEnrolledStudents { get; set;}
        public string CourseDuration { get; set;}
    }
}