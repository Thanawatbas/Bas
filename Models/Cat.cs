using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pp.Models
{
    [Table("Cat")]
    public partial class Cat
    {
        [Column("CatID")]
        [StringLength(10)]
        public string CatId { get; set; }
        [StringLength(50)]
        public string Catname { get; set; }
    }
}
