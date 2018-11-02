using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pp.Models
{
    [Table("initial")]
    public partial class Initial
    {
        [Key]
        [Column("initialCode")]
        [StringLength(10)]
        public string InitialCode { get; set; }
        [Column("initialName")]
        [StringLength(50)]
        public string InitialName { get; set; }
    }
}
