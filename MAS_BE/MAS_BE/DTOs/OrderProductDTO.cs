namespace MAS_BE.DTOs
{
    public class OrderProductDTO
    {
        public int IdOrderProduct { get; set; }

        public int IdProduct { get; set; }

        public int IdOrder { get; set; }

        public string Title { get; set; }
        public float Price { get; set; }


    }
}
