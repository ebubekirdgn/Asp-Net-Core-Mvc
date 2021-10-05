using Edura.Entity;
using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edura.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductRepository _repository;
        private IUnitOfWork _uow;

        public HomeController(IUnitOfWork uow, IProductRepository repository)
        {
            _repository = repository;
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View(_uow.Products.GetAll().Where(x => x.IsApproved == true && x.IsHome == true).ToList());
        }

        public IActionResult Details(int id)
        {
            return View(_uow.Products.Get(id));
        }

        public IActionResult Create()
        {
            var prd = new Product()
            {
                ProductName = "Yeni Ürün",
                Price = 1000
            };

            _uow.Products.Add(prd);
            _uow.SaveChanges();
            _uow.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}