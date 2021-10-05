using System;

namespace Edura.Repository.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        ICategoryRepository Categories { get; }

        int SaveChanges();
    }
}