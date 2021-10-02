using System.Collections.Generic;

namespace Edura.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<ProductCategory> ProductCategories { get; set; } //Coka Cok yapı kurduk.
    }
}