namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Chuongtrinh")]
    public partial class Chuongtrinh
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? idchinhanh { get; set; }

        [StringLength(50)]
        public string logo { get; set; }

        [StringLength(50)]
        public string MACT { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        public int? STT { get; set; }

        [StringLength(50)]
        public string mota { get; set; }

        public DateTime? updatetime { get; set; }

        public bool? enable { get; set; }

        public int? style_diemdanh { get; set; }

        public int? style_diem { get; set; }

        [StringLength(50)]
        public string testDauvao { get; set; }

        [Column(TypeName = "ntext")]
        public string baigioithieu { get; set; }
    }
}
