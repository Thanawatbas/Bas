using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pp.Models
{
    [Table("Product")]
    public partial class Product
    {
        [Key]
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        public int? Price { get; set; }
        public int? Unitprice { get; set; }
        public int? Qty { get; set; }
        public short? Status { get; set; }
        [StringLength(2)]
        public string UnitCode { get; set; }
        [Column("CatID")]
        [StringLength(10)]
        public string CatId { get; set; }
    }
}
