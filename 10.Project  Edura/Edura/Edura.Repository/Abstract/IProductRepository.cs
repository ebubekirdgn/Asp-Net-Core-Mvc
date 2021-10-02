using Edura.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edura.Repository.Abstract
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
