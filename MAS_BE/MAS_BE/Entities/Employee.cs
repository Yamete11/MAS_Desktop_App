using System;

namespace MAS_BE.Entities
{
    public class Employee : Human
    {
        public string Code { get; set; }
        public string Adress { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public bool Student { get; set; }

        public static float DISCOUNT = 0.5f;
    }
}
