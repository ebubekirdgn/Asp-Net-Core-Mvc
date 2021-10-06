using Edura.Entity;
using Edura.Entity.Models;
using Edura.Repository.Abstract;
using Edura.WebUI.Repository.Concrete.EntityFramework;
using System.Collections.Generic;
using System.Linq;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(EduraContext context) : base(context)
        {
        }

        public EduraContext EduraContext
        {
            get { return context as EduraContext; }
        }

        public IEnumerable<CategoryModel> GetAllWithProductCount()
        {
            return GetAll().Select(i => new CategoryModel()
            {
                CategoryId = i.CategoryId,
                CategoryName = i.CategoryName,
                Count = i.ProductCategories.Count()
            });
        }

        public Category GetByName(string name)
        {
            return EduraContext.Categories.Where(i => i.CategoryName == name).FirstOrDefault();
        }
    }
}