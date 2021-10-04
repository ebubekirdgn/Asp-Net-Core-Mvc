using Edura.Entity;
using Edura.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

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

        public void Add(Product entity)
        {
            _context.Products.Add(entity);
        }

        public void Delete(Product entity)
        {
            _context.Products.Remove(entity);
        }

        public void Edit(Product entity)
        {
            _context.Entry<Product>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<Product> Find(Expression<Func<Product, bool>> predicate)
        {
            return _context.Products.Where(predicate);
        }

        public Product Get(int id)
        {
            return _context.Products.FirstOrDefault(i => i.ProductId == id);
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }

        public List<Product> Gettop5Products()
        {
            return _context.Products.OrderByDescending(i => i.ProductId)
                .Take(5)
                .ToList();
        }
         
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}