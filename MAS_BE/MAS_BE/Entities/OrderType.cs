using System.Collections.Generic;

namespace MAS_BE.Entities
{
    public class OrderType
    {
        public int IdOrderType { get; set; }
        public string Title { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}
