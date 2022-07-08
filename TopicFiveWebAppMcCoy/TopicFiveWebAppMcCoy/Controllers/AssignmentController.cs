using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TopicFiveWebAppMcCoy.Models;


namespace TopicFiveWebAppMcCoy.Controllers
{
    public class AssignmentController : Controller
    {
        private AssignmentContext context { get; set; }

        public AssignmentController(AssignmentContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Assignment());
        }
         
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var assignment = context.Assignments.Find(id);
            return View(assignment);
        }


        [HttpPost]
        public IActionResult Edit(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                if (assignment.AssignmentId == 0)
                    context.Assignments.Add(assignment);
                else
                    context.Assignments.Update(assignment);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (assignment.AssignmentId == 0) ? "Add" : "Edit";
                return View(assignment);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var assignment = context.Assignments.Find(id);
            return View(assignment);
        }
        [HttpPost]
        public IActionResult Delete(Assignment assignment)
        {
            context.Assignments.Remove(assignment);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
