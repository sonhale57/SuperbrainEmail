namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Donhang")]
    public partial class Donhang
    {
        public int id { get; set; }

        public int? idcat { get; set; }

        public int? iddongia { get; set; }

        public int? iduser { get; set; }

        public int? idchinhanh { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? soluong { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? thanhtien { get; set; }

        [StringLength(500)]
        public string ghichu { get; set; }

        public DateTime? ngaygui { get; set; }
    }
}
