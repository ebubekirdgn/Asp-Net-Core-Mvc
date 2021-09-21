using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{

    // localhost:5000/course
    public class CourseController : Controller
    {
        // action method
        // localhost:5000/course/index => course/index.cshtml
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View("MyView");
        }

        // localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
            return View();
        }
    }
}