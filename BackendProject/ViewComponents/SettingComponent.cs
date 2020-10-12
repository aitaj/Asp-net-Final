using BackendProject.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendProject.ViewComponents
{
    public class SettingComponent : ViewComponent
    {
        private readonly BackEndProjectDbContext _context;

         public SettingComponent(BackEndProjectDbContext context)
        {
             _context = context ;
           
        }

        public IViewComponentResult Invoke()
        {
            var model = _context.Settings.FirstOrDefault();

            return View(model);
        }

     
    }
}
