using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MAS_BE.Entities
{
    public class Ingridient
    {
        [Key]
        public int IdIngridient { get; set; }

        public string Title { get; set; }
        public float Weight { get; set; }

        public ICollection<ProductIngridient> ProductIngridients { get; set; }
    }
}
