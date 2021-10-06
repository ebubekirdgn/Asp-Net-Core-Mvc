using System.ComponentModel.DataAnnotations;

namespace Edura.Entity
{
    public class ProductAttribute
    {
        [Key]
        public int ProductAttributedId { get; set; }

        public string Attribute { get; set; } // islemci sececegiz sonra value'sini girecegiz.
        public string Value { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}