using Edura.Entity;
using System.Collections.Generic;

namespace Edura.Repository.Abstract
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        List<Product> Gettop5Products();
    }
}