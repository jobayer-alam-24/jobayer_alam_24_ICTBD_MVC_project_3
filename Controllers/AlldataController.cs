using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace jobayer_alam_24_ICTBD_MVC_project_3.Controllers
{
    public class AlldataController : Controller
    {
        private readonly ILogger<AlldataController> _logger;

        public AlldataController(ILogger<AlldataController> logger)
        {
            _logger = logger;
        }

        public IActionResult Data()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}