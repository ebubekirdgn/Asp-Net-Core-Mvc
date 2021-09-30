using Microsoft.AspNetCore.Mvc;
using UrlRouting.Models;

namespace UrlRouting.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View("MyView", new Result()
            {
                Controller = "CustomerController",
                Action = "Index"
            });
        }

        public IActionResult List()
        {
            return View("MyView", new Result()
            {
                Controller = "CustomerController",
                Action = "List"
            });
        }
    }
}