using CourseApp.Models;
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

        // localhost:5000/course/apply
        public IActionResult Apply()
        {
            return View();
        }


        public IActionResult Details()
        {
            var course = new Course();
            course.Name = "Core Mvc Kursu";
            course.description = "güzel bir kurs";
            course.isPublished = true;

            return View(course);
        }

        // localhost:5000/course/list => course/list.cshtml
        public IActionResult List()
        {
            return View();
        }
    }
}