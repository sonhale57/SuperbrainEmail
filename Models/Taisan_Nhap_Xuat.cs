namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Taisan_Nhap_Xuat
    {
        public int id { get; set; }

        public int? idChiNhanh { get; set; }

        public int? iddangkygroup { get; set; }

        public int? idphieunhap { get; set; }

        public int? iduser { get; set; }

        public DateTime? ngay { get; set; }

        public int? idtaisan { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? soluong { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tongtien { get; set; }

        [Column(TypeName = "ntext")]
        public string ghichu { get; set; }

        public int? type { get; set; }

        public int? grouptype { get; set; }

        public int? id_dkKhuyenmai { get; set; }

        public int? status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? CK { get; set; }

        public int? idhocvien { get; set; }

        public int? Follow_khoahoc { get; set; }

        public int? idPhieuXuat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GiaXuat { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? thanhtien { get; set; }

        [StringLength(50)]
        public string donvi { get; set; }

        public int? idtaisancs { get; set; }

        public int? loailenh { get; set; }

        public int? idNcc { get; set; }
    }
}
