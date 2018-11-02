using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pp.Models
{
    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [StringLength(4)]
        public string CustId { get; set; }
        [Column("initialCode")]
        [StringLength(10)]
        public string InitialCode { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        public short? CustType { get; set; }
    }
}
