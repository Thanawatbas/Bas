using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pp.Models
{
    [Table("Status")]
    public partial class Status
    {
        [Key]
        [Column("Status")]
        public short Status1 { get; set; }
        [StringLength(50)]
        public string StatusName { get; set; }
    }
}
