using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogGrid()
        {
            return View();
        }
        public IActionResult LeftSidebar()
        {
            return View();
        }
    }
}
