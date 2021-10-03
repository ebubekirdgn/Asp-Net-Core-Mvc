using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _repository;

        public HomeController(IProductRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            return View(_repository.Products);
        }
    }
}