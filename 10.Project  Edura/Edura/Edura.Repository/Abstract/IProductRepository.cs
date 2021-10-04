using Edura.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Edura.Repository.Abstract
{
    public interface IProductRepository
    {
        Product Get(int id);
        IQueryable<Product> GetAll();
        IQueryable<Product> Find(Expression<Func<Product, bool>> predicate);
        void Add(Product entity);
        void Delete(Product entity);
        void Edit(Product entity);
        void Save();
    }
}