using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BuildingForms.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BuildingForms.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(ProductRepository.Products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(new List<string>() { "Telefon", "Tablet", "Laptop" });


            return View();
        }

        [HttpPost]
        public IActionResult Create(Product model)
        {
            //Validation
            ProductRepository.AddProduct(model);
            return RedirectToAction("Index");
        }

        //Home/Search?q=kelime
        [HttpGet]
        public IActionResult Search(string q)
        {
            if (string.IsNullOrWhiteSpace(q))
                return View();

            return View("Index", ProductRepository.Products.Where(a => a.Name.Contains(q)));
        }
    }
}