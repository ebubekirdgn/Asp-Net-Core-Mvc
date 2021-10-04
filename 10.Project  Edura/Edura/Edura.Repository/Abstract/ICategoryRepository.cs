using Edura.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Edura.Repository.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetByName(string name);
    }
}
