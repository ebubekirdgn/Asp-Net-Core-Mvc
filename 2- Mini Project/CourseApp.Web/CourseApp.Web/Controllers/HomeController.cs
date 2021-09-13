using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return View();
            //return Content("Hello World.");
            //return NotFound();
            return new EmptyResult();
            //return RedirectToAction("List","Home",new { id=5,sortBy="name"});
        }

        public IActionResult List()
        {
            return View();
        }
    }
}