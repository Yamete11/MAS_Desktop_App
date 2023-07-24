using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int IdOrderType { get; set; }

        [Required]
        [ForeignKey(nameof(IdOrderType))]
        public OrderType OrderType { get; set; }

        public int? TableNumber { get; set; }

        
        public int? IdReceipt { get; set; }

        [ForeignKey(nameof(IdReceipt))]
        public virtual Receipt Receipt { get; set; }
    }
}
