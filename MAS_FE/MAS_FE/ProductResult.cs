﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_FE
{
    public class ProductResult
    {
        public int IdOrder { get; set; }
        public List<int> IdProducts { get; set; }

        public override string? ToString()
        {
            return $"{IdOrder} | {IdProducts}";
        }
    }
}
