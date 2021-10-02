using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edura.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName{ get; set; }
        public double Price { get; set; }

        //Bire - Cok iliski kurmak icin
        public int CategoryId { get; set; }
        public Category Category{ get; set; }
    }
}
