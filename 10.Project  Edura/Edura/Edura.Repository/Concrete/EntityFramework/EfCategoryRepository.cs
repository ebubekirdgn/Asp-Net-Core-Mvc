using Edura.Entity;
using Edura.Repository.Abstract;
using Edura.WebUI.Repository.Concrete.EntityFramework;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : EfGenericRepository<Category>, ICategoryRepository
    {
        public EfCategoryRepository(EduraContext context) :base(context)
        {

        }

        public EduraContext EduraContext
        {
            get { return context as EduraContext; }
        }
        public Category GetByName(string name)
        {
            return EduraContext.Categories.Where(i => i.CategoryName == name).FirstOrDefault();
        }
    }
}