using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class BaseController : Controller
    {

        private readonly BackEndProjectDbContext _context;

        public BaseController()
        {
            _context = new BackEndProjectDbContext();

           
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
