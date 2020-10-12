using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackendProject.Data;
using BackendProject.Models;
using BackendProject.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace BackendProject.Controllers
{
    public class HomeController : Controller
    {
        public readonly BackEndProjectDbContext _context;

        public HomeController(BackEndProjectDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                HomeHeroSliders = _context.HomeHeroSlider.OrderByDescending(i => i.Id).ToList(),
                PromoBlocks=_context.PromoBlocks.OrderByDescending(i=>i.Id).Take(4).ToList(),
                AboutUsText=_context.AboutUsTexts.OrderByDescending(i=>i.Id).FirstOrDefault(),
                Services =_context.Services.ToList(),
                ServicesCards = _context.ServicesCards.ToList()
            };

            return View(model);
        }
    }
}
