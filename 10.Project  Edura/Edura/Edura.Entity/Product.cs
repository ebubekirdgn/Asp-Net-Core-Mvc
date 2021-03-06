using System;
using System.Collections.Generic;

namespace Edura.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
         
        public string Description { get; set; }
        public string HtmlContent { get; set; }
        public DateTime DateAdded { get; set; }

        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }

        // public Category Category{ get; set; }  //Bire - Cok iliski kurmak icin
        public List<ProductCategory> ProductCategories { get; set; } //Coka Cok yapı kurduk.
        public List<Image> Images { get; set; }
        public List<ProductAttribute> Attributes { get; set;}
    }
}