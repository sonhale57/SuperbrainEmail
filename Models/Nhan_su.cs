namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nhan_su
    {
        public int id { get; set; }

        [StringLength(50)]
        public string block1 { get; set; }

        public int? idchinhanh { get; set; }

        [StringLength(500)]
        public string hinhanh { get; set; }

        [StringLength(50)]
        public string Mans { get; set; }

        [StringLength(500)]
        public string hoten { get; set; }

        [StringLength(500)]
        public string diachi { get; set; }

        public DateTime? ngaysinh { get; set; }

        [StringLength(50)]
        public string gioitinh { get; set; }

        [StringLength(500)]
        public string dienthoai { get; set; }

        [StringLength(500)]
        public string email { get; set; }

        [StringLength(50)]
        public string block2 { get; set; }

        [StringLength(500)]
        public string trinhdo { get; set; }

        [StringLength(50)]
        public string nghiepvu { get; set; }

        [StringLength(500)]
        public string daotao { get; set; }

        [StringLength(500)]
        public string chuongtrinh { get; set; }

        [StringLength(200)]
        public string khoahoc { get; set; }

        [StringLength(200)]
        public string vitri { get; set; }

        [StringLength(500)]
        public string soCMND { get; set; }

        [StringLength(500)]
        public string tinhtrang { get; set; }

        [StringLength(500)]
        public string Chuyennganh { get; set; }

        [StringLength(500)]
        public string chucvu { get; set; }

        [StringLength(1000)]
        public string ghichu { get; set; }

        public DateTime? updatetime { get; set; }

        public int? enable { get; set; }

        [StringLength(500)]
        public string tentk { get; set; }

        [StringLength(500)]
        public string matkhau { get; set; }

        public DateTime? hansudung { get; set; }

        public DateTime? ngaythamgia { get; set; }

        public int? iduser { get; set; }

        public int? isTaphuan { get; set; }

        public int? temp { get; set; }

        public double? rate { get; set; }

        public bool? ketqua { get; set; }

        [StringLength(50)]
        public string cmnd { get; set; }
    }
}
