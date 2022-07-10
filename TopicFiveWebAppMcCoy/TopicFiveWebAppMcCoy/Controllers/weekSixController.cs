using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopicFiveWebAppMcCoy.Models;

namespace TopicFiveWebAppMcCoy.Controllers
{
    public class WeekSixController : Controller
    {
        private StudentContext context { get; set; }
        public WeekSixController(StudentContext ctx)
        {
            context = ctx;
        }

        public IActionResult SixPointOne(int? Author)
        {
            string stringAuthor = Author.ToString();
            var students = context.StudentList.OrderBy(s => s.StudentID).ToList();
            return View(stringAuthor, students);
        } 
        public IActionResult Index()
        {
            return View();
        }
    }
}
