using Abp.Web.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
using TopicFiveWebAppMcCoy.Models;

namespace TopicFiveWebAppMcCoy.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        //private AssignmentContext context { get; set; }

        //public HomeController(AssignmentContext ctx)
        //{
        //    context = ctx;
        //}
        //public IActionResult Index()
        //{
        //    var assignments = context.Assignments.OrderBy(a => a.Name).ToList();
        //    return View(assignments);
        //}

        //public IActionResult Privacy()
        //{
        //    return View();
        //}


        private AssignmentContext context { get; set; }

        public HomeController(AssignmentContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var assignments = context.Assignments.OrderBy(a => a.Name).ToList();
            return View(assignments);
        }
        public ViewResult ExampleOne()
        {
            return View();
        }
        public ViewResult ExampleTwo()
        {
            return View();
        }
        [Route("/CustomRoutingAttribute")]
        public ViewResult ExampleThree()
        {
            return View();
        }



        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
