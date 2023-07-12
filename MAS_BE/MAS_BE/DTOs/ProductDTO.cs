namespace MAS_BE.DTOs
{
    public class ProductDTO
    {
        public int IdProduct { get; set; }

        public string Title { get; set; }
        public float Price { get; set; }
        public int IdProductCategory { get; set; }
    }
}
