using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAS_BE.Entities
{
    public class Manager : Employee
    {
        [Key]
        public int IdManager { get; set; }

        public float SALARY { get; set; } 

        public ICollection<Report> Reports { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
