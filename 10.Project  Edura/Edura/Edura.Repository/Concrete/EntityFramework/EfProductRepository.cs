using Edura.Entity;
using Edura.Repository.Abstract;
using System;
using System.Linq;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : IProductRepository
    {
        private EduraContext _context;

        public EfProductRepository(EduraContext context)
        {
            _context = context;
        }

        public IQueryable<Product> Products => _context.Products;
    }
}