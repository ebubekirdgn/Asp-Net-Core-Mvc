using System.Collections.Generic;

namespace Edura.Entity.Models
{
    public class ProductListModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}