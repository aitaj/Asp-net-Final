using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackendProject.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using BackendProject.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using BackendProject.Data;

namespace BackendProject.Controllers
{
    public class HomePageController : Controller
    {
        private readonly ILogger<HomePageController> _logger;

        private readonly BackEndProjectDbContext _context;

      

        public HomePageController(ILogger<HomePageController> logger)
        {
            _logger = logger;
        }



        public new IActionResult Index()
        {
          
            return View();
        }

        
    }
}
