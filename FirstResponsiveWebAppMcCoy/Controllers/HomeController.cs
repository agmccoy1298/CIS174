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
            if (ModelState.IsValid)
            {
                ViewBag.CurrentAge = model.AgeThisYear();
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
