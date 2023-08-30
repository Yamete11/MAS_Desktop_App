using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_BE.Entities
{
    public class ProductIngridient
    {
        [Key]
        public int IdProductIngridient { get; set; }

        public int IdIngridient { get; set; }

        [Required]
        [ForeignKey(nameof(IdIngridient))]
        public Ingridient Ingridient { get; set; }

        public int IdProduct { get; set; }

        [Required]
        [ForeignKey(nameof(IdProduct))]
        public Product Product { get; set; }
    }
}
