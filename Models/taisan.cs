namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("taisan")]
    public partial class taisan
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        public int? idcat { get; set; }

        public int? iduser { get; set; }

        [StringLength(25)]
        public string Masanpham { get; set; }

        [StringLength(100)]
        public string ten { get; set; }

        [StringLength(100)]
        public string diengiai { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? gia { get; set; }

        [StringLength(10)]
        public string donvi { get; set; }

        public int? enable { get; set; }

        public DateTime? Updatetime { get; set; }

        public int? idChiNanh { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongia { get; set; }
    }
}
