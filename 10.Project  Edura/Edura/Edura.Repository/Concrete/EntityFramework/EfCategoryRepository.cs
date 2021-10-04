using Edura.Entity;
using Edura.Repository.Abstract;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Edura.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        private EduraContext _context;

        public EfCategoryRepository(EduraContext context)
        {
            _context = context;
        }

        public IQueryable<Category> Categories => _context.Categories;

        public void Add(Category entity)
        {
            _context.Categories.Add(entity);
        }

        public void Delete(Category entity)
        {
            _context.Categories.Remove(entity);
        }

        public void Edit(Category entity)
        {
            _context.Entry<Category>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<Category> Find(Expression<Func<Category, bool>> predicate)
        {
            return _context.Categories.Where(predicate);
        }

        public Product Get(int id)
        {
            return _context.Products.FirstOrDefault(i => i.ProductId == id);
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products;
        }

        public Category GetByName(string name)
        {
            return _context.Categories.Where(i => i.CategoryName == name).FirstOrDefault();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        Category IGenericRepository<Category>.Get(int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<Category> IGenericRepository<Category>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}