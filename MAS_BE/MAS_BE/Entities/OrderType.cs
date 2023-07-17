using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAS_BE.Entities
{
    public class OrderType
    {
        [Key]
        public int IdOrderType { get; set; }
        public string Title { get; set; }
        public ICollection<Order> Orders { get; set; }


    }
}
