using System;
using System.Collections.Generic;

namespace ModelBinding.Models
{
    public class Repository : IRepository
    {
       // private List<Customer> _customers;

        public Repository()
        {

     
        }

        public List<Customer> Customers => throw new NotImplementedException();

        public Customer Get(int customerId)
        {
            throw new NotImplementedException();
        }
    }

}