namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PhieuNhap_xuat
    {
        public int id { get; set; }

        [StringLength(20)]
        public string madk { get; set; }

        public int? iduser { get; set; }

        public int? Idngoaite { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tygia { get; set; }

        public int? idkhachhang { get; set; }

        public int? idchinhanh { get; set; }

        public int? Loai { get; set; }

        public DateTime? thoigian { get; set; }

        [StringLength(50)]
        public string ChungTuLienQuan { get; set; }

        [StringLength(100)]
        public string NguoiGiao { get; set; }

        [StringLength(100)]
        public string DiaDiem { get; set; }

        [StringLength(200)]
        public string Ghichu { get; set; }

        public int? LanInPhieu { get; set; }

        public int? SoLanSua { get; set; }

        public DateTime? Updatetime { get; set; }

        public int? HinhThucThanhToan { get; set; }

        public bool? enable { get; set; }

        public int? status { get; set; }
    }
}
