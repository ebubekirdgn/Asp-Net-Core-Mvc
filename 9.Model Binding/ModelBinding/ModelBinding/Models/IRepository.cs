using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelBinding.Models
{
    public interface IRepository
    {
        List<Customer> Customers { get; }
        Customer Get(int customerId);
    }
}
