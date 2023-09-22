namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoaTapHuan")]
    public partial class KhoaTapHuan
    {
        public int id { get; set; }

        [StringLength(250)]
        public string Ten { get; set; }

        public int? Type { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fromdate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Todate { get; set; }

        public int? Soluong { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Gia { get; set; }

        [StringLength(500)]
        public string Mota { get; set; }

        [StringLength(250)]
        public string LinkDK { get; set; }

        public int? Trangthai { get; set; }

        public int? iduser { get; set; }

        public int? uudai { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateup { get; set; }

        [Column("object")]
        public int? _object { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Expire { get; set; }
    }
}
