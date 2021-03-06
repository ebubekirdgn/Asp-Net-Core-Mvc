using Edura.Repository.Abstract;
using Edura.Repository.Concrete.EntityFramework;
using System;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly EduraContext _dbContext;
        public EfUnitOfWork(EduraContext dbContext)
        {
            //dbContext boş ise dedik '??' bunula
            _dbContext = dbContext ?? throw new ArgumentException("dbcontext can not be null!");
        }

        public IProductRepository _products;

        public ICategoryRepository _categories;


        public IProductRepository Products
        {
            get
            {
                return _products ?? (_products = new EfProductRepository(_dbContext));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EfCategoryRepository(_dbContext));
            }
        }
       

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public int SaveChanges()
        {
            try
            {
                return _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}