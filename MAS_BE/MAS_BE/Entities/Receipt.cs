using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_BE.Entities
{
    public class Receipt
    {
        public int IdReceipt { get; set; }
        public float Sum { get; set; }
        public string? NIP { get; set; }

        public int IdOrder { get; set; }

        [Required]
        [ForeignKey(nameof(IdOrder))]
        public Order Order { get; set; }
    }
}
