using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edura.WebUI.Components
{
    public class FeaturedProducts : ViewComponent
    {
        private IProductRepository repository;

        public FeaturedProducts(IProductRepository _repository)
        {
            repository = _repository;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository
                .GetAll()
                .Where(x => x.IsApproved && x.IsFeatured)
                .ToList());
        }
    }
}