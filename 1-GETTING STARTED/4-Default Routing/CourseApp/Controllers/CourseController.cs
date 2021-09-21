using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{

    // localhost:5000/course
    public class CourseController : Controller
    {
        // action method
        // localhost:5000/course/index
        public string Index()
        {
            return "Course/Index";
        }

        // localhost:5000/course/list
        public string List()
        {
            return "Course/List";
        }
    }
}