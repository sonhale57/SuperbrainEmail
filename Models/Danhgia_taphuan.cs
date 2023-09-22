namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Danhgia_taphuan
    {
        public int id { get; set; }

        public int idnhansu { get; set; }

        public int? diem { get; set; }

        [Column(TypeName = "ntext")]
        public string mota { get; set; }

        public int idkhoataphuan { get; set; }

        public bool? tinhtrang { get; set; }

        public int? idchinhanh { get; set; }

        public int? iduser { get; set; }

        public DateTime? dateup { get; set; }

        public int? ketqua { get; set; }

        public int? number { get; set; }

        [Column(TypeName = "ntext")]
        public string chuyenmon { get; set; }

        [Column(TypeName = "ntext")]
        public string kynang { get; set; }

        [Column(TypeName = "ntext")]
        public string thaido { get; set; }

        [Column(TypeName = "ntext")]
        public string caithien { get; set; }

        [Column(TypeName = "ntext")]
        public string tuvan { get; set; }

        [Column(TypeName = "ntext")]
        public string dunglop { get; set; }

        [Column(TypeName = "ntext")]
        public string nhanxetchung { get; set; }

        public int? chuyenmon1 { get; set; }

        public int? chuyenmon2 { get; set; }

        public int? chuyenmon3 { get; set; }

        public int? chuyenmon4 { get; set; }

        public int? chuyenmon5 { get; set; }

        public int? chuyenmon6 { get; set; }

        public int? chuyenmon7 { get; set; }

        [Column(TypeName = "ntext")]
        public string thaido1 { get; set; }

        [Column(TypeName = "ntext")]
        public string thaido2 { get; set; }

        [Column(TypeName = "ntext")]
        public string thaido3 { get; set; }

        [Column(TypeName = "ntext")]
        public string thaido4 { get; set; }

        public int? diemonline { get; set; }
    }
}
