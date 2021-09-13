using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseApp.Web.Models;

namespace CourseApp.Web.Controllers
{
    public class HomeController : Controller
    {      
        public IActionResult Index()
        {
            return View();
            //return Content("Hello World.");
            //return NotFound();
            //return new EmptyResult();
            //return RedirectToAction("List","Home",new { id=5,sortBy="name"});
        }

        public IActionResult List()
        {
            return View();
        }
    }
}