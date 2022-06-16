using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppMcCoy.Models;

namespace FirstResponsiveWebAppMcCoy.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Name = "";
            ViewBag.CurrentAge = 0;
            return View();
        }
        [HttpPost]
        public IActionResult Index(AgeModel model)
        {
            DateTime date = model.Date;
            int birthYear = model.BirthYear.Value;          

            if (ModelState.IsValid)
            {
                ViewBag.CurrentAge = AgeModel.AgeThisYear(date, birthYear);
                ViewBag.Name = model.FullName;
            }
            else
            {
                
                ViewBag.CurrentAge = 0;
            }
            return View(model);
        }
    }
}
