using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_FE
{
    public class Order
    {
        public int IdOrder { get; set; }

        public float Sum { get; set; }

        public DateTime CreateAt { get; set; }

        public int? IdReceipt { get; set; }

        public override string? ToString()
        {
            return $"Id: {IdOrder} | Sum: {Sum} | Created at: {CreateAt}";
        }
    }
}
