using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_FE
{
    public class OrderProduct
    {
        public int IdOrderProduct { get; set; }

        public int IdProduct { get; set; }

        public int IdOrder { get; set; }

        public string Title { get; set; }
        public float Price { get; set; }

        public override string? ToString()
        {
            return $"Id: {IdProduct} | Title: {Title} | Price: {Price}";
        }
    }
}
