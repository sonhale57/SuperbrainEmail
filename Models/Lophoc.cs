namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lophoc")]
    public partial class Lophoc
    {
        public int id { get; set; }

        public int? idchuongtrinh { get; set; }

        public int? idkhoahoc { get; set; }

        public int? STT { get; set; }

        [StringLength(500)]
        public string ten { get; set; }

        public DateTime? ngaybatdau { get; set; }

        public DateTime? ngayketthuc { get; set; }

        public int? iduser { get; set; }

        public int? enable { get; set; }

        public int? idChiNhanh { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(1000)]
        public string mota { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? buoihoc { get; set; }
    }
}
