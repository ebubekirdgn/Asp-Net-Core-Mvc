using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Components
{
    public class FeaturedProducts : ViewComponent
    {
        private IProductRepository repository;

        public FeaturedProducts(IProductRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(repository
                .GetAll()
                .Where(x => x.IsApproved && x.IsFeatured)
                .ToList());
        }
    }
}