namespace Edura.Entity
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public int ProductId { get; set; } // Her resim bir urunle eslestirilmeli
        public Product Product { get; set; }
    }
}