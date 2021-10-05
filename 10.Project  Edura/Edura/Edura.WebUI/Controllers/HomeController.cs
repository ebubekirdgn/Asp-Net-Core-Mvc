using Edura.Entity;
using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _repository;
        private IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork, IProductRepository repository)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }

        public IActionResult Details(int id)
        {
            return View(_repository.Get(id));
        }

        public IActionResult Create ()
        {
            var product = new Product() { ProductName="Yeni Ürün" ,Price=1500};
            _unitOfWork.Products.Add(product);
            _unitOfWork.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}