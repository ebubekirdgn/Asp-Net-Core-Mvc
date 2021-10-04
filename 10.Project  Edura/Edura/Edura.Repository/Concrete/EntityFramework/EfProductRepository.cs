using Edura.Entity;
using Edura.Repository.Abstract;
using Edura.WebUI.Repository.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository
    {

        public EfProductRepository(EduraContext context) : base(context)
        {

        }

        public EduraContext EduraContext
        {
            get { return context as EduraContext; }
        }

        public List<Product> Gettop5Products()
        {
            return EduraContext.Products.OrderByDescending(x => x.ProductId).Take(5).ToList();

        }
    }
}
