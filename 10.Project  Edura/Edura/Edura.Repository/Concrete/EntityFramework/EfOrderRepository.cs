using Edura.Entity;
using Edura.Repository.Concrete.EntityFramework;
using Edura.WebUI.Repository.Abstract;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Edura.WebUI.Repository.Concrete.EntityFramework
{
    public class EfOrderRepository : IOrderRepository
    {
        private EduraContext _context;

        public EfOrderRepository(EduraContext context)
        {
            _context = context;
        }

        public void Add(Order entity)
        {
            _context.Orders.Add(entity);
        }

        public void Delete(Order entity)
        {
            _context.Orders.Remove(entity);
        }

        public void Edit(Order entity)
        {
            _context.Entry<Order>(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public IQueryable<Order> Find(Expression<Func<Order, bool>> predicate)
        {
            return _context.Orders.Where(predicate);
        }

        public Order Get(int id)
        {
            return _context.Orders.FirstOrDefault(i => i.OrderId == id);
        }

        public IQueryable<Order> GetAll()
        {
            return _context.Orders;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}