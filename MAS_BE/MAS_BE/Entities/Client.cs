using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAS_BE.Entities
{
    public class Client : Human
    {
        [Key]
        public int IdClient { get; set; }
        public string NIP { get; set; }
        public bool Discount { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
