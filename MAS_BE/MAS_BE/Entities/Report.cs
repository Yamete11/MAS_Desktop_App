using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAS_BE.Entities
{
    public class Report
    {
        [Key]
        public int IdReport { get; set; }

        public DateTime CreateAt { get; set; }

        public float Revenue { get; set; }

        public int OrderQuantity { get; set; }

        public int? IdManger { get; set; }

        [ForeignKey(nameof(IdManger))]
        public Manager Manager { get; set; }

    }
}
