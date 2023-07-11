using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAS_BE.Entities
{
    public class Order
    {

        [Key]
        public int IdOrder { get; set; }

        public float Sum { get; set; }

        public DateTime CreateAt { get; set; }

        public DateTime? ClosedAt { get; set; }

        
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
