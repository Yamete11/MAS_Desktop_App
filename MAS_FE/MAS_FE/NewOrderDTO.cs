using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_FE
{
    internal class NewOrderDTO
    {
        public List<int> IdProducts { get; set; }
        public int IdOrderType { get; set; }
        public int? TableNumber { get; set; }
    }
}
