using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopicFiveWebAppMcCoy.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult List(string id = "All")
        {
            return Content("Product controller, List action, id: " + id);
        }
        [Route("About")]
        public IActionResult Detail(int id)
        {
            return Content("Product controller, Detail action, id: " + id);
        }
    }
}
