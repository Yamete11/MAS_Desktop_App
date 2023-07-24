using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_BE.Entities
{

    public enum PaymentMethod
    {
        Cash,
        MasterCard,
        Visa
    }
    public partial class Receipt
    {
        [Key]
        public int IdReceipt { get; set; }
        public DateTime createdAt { get; set; }
        public float Sum { get; set; }
        public string? NIP { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public Order Order { get; set; }
    }
}
