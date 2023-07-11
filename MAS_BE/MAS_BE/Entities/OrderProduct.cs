using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_BE.Entities
{
    public class OrderProduct
    {
        [Key]
        public int IdOrderProduct { get; set; }

        public int IdProduct { get; set; }

        [Required]
        [ForeignKey(nameof(IdProduct))]
        public Product Product { get; set; }

        public int IdOrder { get; set; }

        [Required]
        [ForeignKey(nameof(IdOrder))]
        public Order Order { get; set; }

        public DateTime CreateAt { get; set; }

        public string? Description { get; set; }
    }
}
