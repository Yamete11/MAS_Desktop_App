using System.ComponentModel.DataAnnotations;

namespace MAS_BE.Entities
{
    public class Waiter : Employee
    {

        [Key]
        public int IdWaiter { get; set; }

        public float SALARY = 12.4F;
    }
}
