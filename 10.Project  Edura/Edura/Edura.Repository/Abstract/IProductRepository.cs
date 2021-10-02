using Edura.Entity;
using System.Linq;

namespace Edura.Repository.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}