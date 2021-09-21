using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;       
using Microsoft.AspNetCore.Mvc;
using CourseApp.Web.Models;

namespace CourseApp.Web.Controllers
{
    //course
    public class CourseController : Controller
    {
        //course/index
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "Good Afternoon" : "Good morning";

            return View("MyView");
        }

        //course/list
        public ViewResult List()
        {
            var liste=  Repository.Students.Where(i => i.WillAttend == true);
            return View(liste);
        }

        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }

        [HttpPost]
        public ViewResult Apply(Student student)
        {
            if (ModelState.IsValid)
            {
                Repository.AddStudent(student);
                return View("Thanks", student);
            }
            else
            {
                return View();
            }

          
        }
    }
}