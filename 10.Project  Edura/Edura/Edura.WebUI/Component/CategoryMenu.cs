using Edura.Repository.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Edura.WebUI.Components
{
    public class CategoryMenu : ViewComponent
    {
        private ICategoryRepository repository;
        public CategoryMenu(ICategoryRepository _repository)
        {

            repository = _repository;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(repository.GetAllWithProductCount());
        }
    }
}