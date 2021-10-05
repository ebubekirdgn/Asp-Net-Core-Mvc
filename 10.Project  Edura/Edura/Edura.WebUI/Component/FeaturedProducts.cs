using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Edura.WebUI.Components
{
    public class FeaturedProducts : ViewComponent
    {
        private IProductRepository _repository;

        public FeaturedProducts(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_repository
                .GetAll()
                .Where(x => x.IsApproved && x.IsFeatured)
                .ToList());
        }
    }
}