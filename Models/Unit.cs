using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pp.Models
{
    [Table("Unit")]
    public partial class Unit
    {
        [Key]
        [StringLength(2)]
        public string UnitCode { get; set; }
        [StringLength(50)]
        public string Unitname { get; set; }
    }
}
