using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pp.Models
{
    [Table("CustType")]
    public partial class CustType
    {
        [Key]
        [Column("CustType")]
        public short CustType1 { get; set; }
        [StringLength(50)]
        public string NameType { get; set; }
    }
}
