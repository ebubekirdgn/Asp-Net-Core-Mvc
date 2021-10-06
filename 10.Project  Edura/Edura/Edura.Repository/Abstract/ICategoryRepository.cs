using Edura.Entity;
using Edura.Entity.Models;
using System.Collections.Generic;

namespace Edura.Repository.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetByName(string name);

        IEnumerable<CategoryModel> GetAllWithProductCount();
    }
}