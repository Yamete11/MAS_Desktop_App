using System;

namespace MAS_BE.DTOs
{
    public class OrderDTO
    {
        public int IdOrder { get; set; }

        public float Sum { get; set; }

        public DateTime CreateAt { get; set; }
    }
}
