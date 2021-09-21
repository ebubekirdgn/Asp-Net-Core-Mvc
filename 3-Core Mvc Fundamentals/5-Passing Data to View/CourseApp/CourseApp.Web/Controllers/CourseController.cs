using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CourseApp.Web.Models;

namespace CourseApp.Web.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var kurs = new Course() {  Id=1, Name="Komple Uygulamalı Web Geliştirme"};

            //ViewData["course"] = kurs;
            //ViewBag.course = kurs;
            ViewBag.count = 10;

            //var viewresult = new ViewResult();
            //viewresult.ViewData.Model

            return View(kurs);
        }

    }
}