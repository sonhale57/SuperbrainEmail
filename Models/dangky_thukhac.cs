namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class dangky_thukhac
    {
        public int id { get; set; }

        public int? idChiNhanh { get; set; }

        public int? iddangkygroup { get; set; }

        public int? idphieunhap { get; set; }

        public int? iduser { get; set; }

        public DateTime? ngay { get; set; }

        [StringLength(1500)]
        public string ten { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? soluong { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongia { get; set; }

        [StringLength(500)]
        public string DVT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tongtien { get; set; }

        [Column(TypeName = "ntext")]
        public string ghichu { get; set; }

        public int? type { get; set; }

        public int? status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CK { get; set; }

        public int? idhocvien { get; set; }

        public int? idPhieuXuat { get; set; }

        public int? grouptype { get; set; }
    }
}
