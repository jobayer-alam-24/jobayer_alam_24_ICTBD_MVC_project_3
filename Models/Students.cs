using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jobayer_alam_24_ICTBD_MVC_project_3.Models
{
    public class Students
    {
        public int StudentsID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Grade { get; set; }
        public string Email  { get; set; }
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}