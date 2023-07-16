using System.Collections.Generic;

namespace MAS_BE.DTOs
{
    public class ProductResultDTO
    {
        public List<int> IdProducts { get; set; }
        public int IdOrder { get; set; }
        public int IdOrderType { get; set; }
        public int? TableNumber { get; set; }
    }
}
