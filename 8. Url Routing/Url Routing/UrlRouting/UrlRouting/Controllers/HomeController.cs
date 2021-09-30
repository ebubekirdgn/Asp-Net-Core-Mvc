using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using UrlRouting.Models;

namespace UrlRouting.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("MyView", new Result() { 
                Controller ="HomeController",
                Action = "Index"
            });
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}