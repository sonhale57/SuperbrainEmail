namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThuChi")]
    public partial class ThuChi
    {
        public int id { get; set; }

        public int? idhocvien { get; set; }

        public int? type { get; set; }

        [StringLength(50)]
        public string code { get; set; }

        public int? idChinhanh { get; set; }

        public int? iduser { get; set; }

        [StringLength(500)]
        public string lydo { get; set; }

        [StringLength(500)]
        public string nguoinhan { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(50)]
        public string loai { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tongtien { get; set; }

        [StringLength(3000)]
        public string bangchu { get; set; }

        [StringLength(200)]
        public string hinhthuc { get; set; }

        public int? idphieudangky { get; set; }

        [StringLength(50)]
        public string dienthoai { get; set; }

        [StringLength(500)]
        public string diachi { get; set; }

        [StringLength(500)]
        public string sochungtu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? chietkhau { get; set; }

        [Column(TypeName = "ntext")]
        public string imageup { get; set; }
    }
}
