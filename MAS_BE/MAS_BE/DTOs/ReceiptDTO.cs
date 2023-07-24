using MAS_BE.Entities;
using System;

namespace MAS_BE.DTOs
{
    public class ReceiptDTO
    {
        public int IdOrder { get; set; }
        public string? NIP { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
