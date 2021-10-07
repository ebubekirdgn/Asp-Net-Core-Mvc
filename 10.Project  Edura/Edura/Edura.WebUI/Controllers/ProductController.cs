using Edura.Entity.Models;
using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Edura.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository _repository;
        public int PageSize = 2; // Bir sayfada kac tane ürün gözükecek onu belirliyoruz.

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProductController/Details/5
        public IActionResult Details(int id)
        {
            return View(_repository
                .GetAll() //asagısı gelirken bunlarıda al gel dedik
                .Where(i => i.ProductId == id)
                .Include(i => i.Images)
                .Include(i => i.Attributes)
                .Include(i => i.ProductCategories)
                .ThenInclude(i => i.Category) // Daha sonradan daha sonrası demektir.
                .Select(i => new ProductDetailsModel()
                {
                    Product = i,
                    ProductImages = i.Images,
                    ProductAttributes = i.Attributes,
                    Categories = i.ProductCategories.Select(a => a.Category).ToList()
                })
                .FirstOrDefault());
        }

        public IActionResult List(string category, int page = 1)
        {
            var products = _repository.GetAll();

            if (!string.IsNullOrEmpty(category))
            {
                products = products
                    .Include(i => i.ProductCategories)
                    .ThenInclude(i => i.Category)
                    .Where(i => i.ProductCategories.Any(a => a.Category.CategoryName == category)); //Any true yada false deger gönderir.
            }
            var count = products.Count();

            products = products.Skip((page - 1) * PageSize).Take(PageSize); //sayfalama yaptık.

            return View(new ProductListModel()
            {
                Products = products,
                PagingInfo = new PagingInfo()
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = count
                }
            });
        }
    }
}