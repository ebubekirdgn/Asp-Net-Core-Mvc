using Edura.Repository.Abstract;
using Edura.Repository.Infrastructure;
using Edura.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    public class CartController : Controller
    {
        private IUnitOfWork unitOfWork;

        public CartController(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        public IActionResult Index()
        {
            return View(GetCart());
        }

        public IActionResult AddToCart(int ProductId, int quantity = 1)
        {
            var product = unitOfWork.Products.Get(ProductId);
            if (product != null)
            {
                var cart = GetCart();
                cart.AddProduct(product, quantity);
                SaveCart(cart);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int ProductId)
        {
            var product = unitOfWork.Products.Get(ProductId); // ex: id ile gelen product alındı.
            if (product != null)
            {
                var cart = GetCart(); //sessiondan aldık.
                cart.RemoveProduct(product); //sildik
                SaveCart(cart);// kartta yaptıgımız degisiklik tekrar alındı.
            }

            return RedirectToAction("Index"); // Kullanıcının karsına silinmis bir sekilde geri dönduk.
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetJson("Cart", cart);
        }

        private Cart GetCart()
        {
            return HttpContext.Session.GetJson<Cart>("Cart") ?? new Cart();
        }
    }
}