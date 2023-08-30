using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_BE.Entities
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        public string Title { get; set; }
        public float Price { get; set; }


        public int IdProductCategory { get; set; }

        [Required]
        [ForeignKey(nameof(IdProductCategory))]
        public ProductCategory ProductCategory { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }

        public ICollection<ProductIngridient> ProductIngridients { get; set; }

    }
}
