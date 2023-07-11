using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAS_BE.Entities
{
    public class ProductCategory
    {
        [Key]
        public int IdProductCategory { get; set; }
        public string Title { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
