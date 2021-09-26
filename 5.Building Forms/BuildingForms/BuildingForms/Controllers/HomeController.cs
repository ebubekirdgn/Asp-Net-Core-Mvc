using BuildingForms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

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
            ViewBag.Categories = new SelectList(new List<string>() { "Telefon", "Tablet", "Laptop","PC" });


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
            //Index viewinin içerisine bastık direk bu arama sonuclarını
            return View("Index", ProductRepository.Products.Where(a => a.Name.Contains(q)));
        }
    }
}