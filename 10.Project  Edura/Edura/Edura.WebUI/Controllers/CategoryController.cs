using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryRepository repository;

        public CategoryController(ICategoryRepository _repository)
        {
            repository = _repository;
        }

        public IActionResult Index()
        {
            var cat = repository.GetByName("Electronics");
            return View(cat);
        }
    }
}