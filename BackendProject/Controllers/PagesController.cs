using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult FAQ()
        {
            return View();
        }
        public IActionResult ProjectDetails()
        {
            return View();
        }
        public IActionResult ServicesDetails()
        {
            return View();
        }
    }
}
