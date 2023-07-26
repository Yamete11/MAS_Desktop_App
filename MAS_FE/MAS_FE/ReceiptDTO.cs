using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_FE
{
    public enum PaymentMethod
    {
        Cash,
        MasterCard,
        Visa
    }
    public class ReceiptDTO
    {
        public int IdOrder { get; set; }
        public string? NIP { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
