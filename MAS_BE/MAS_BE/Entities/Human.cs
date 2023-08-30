using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAS_BE.Entities
{
    public abstract class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string TelNumber { get; set; }
        public string Email { get; set; }

    }
}
