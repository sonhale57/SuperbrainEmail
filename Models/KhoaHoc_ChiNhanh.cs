namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KhoaHoc_ChiNhanh
    {
        public int ID { get; set; }

        public int? iduser { get; set; }

        public int? idchiNhanh { get; set; }

        public int? idchuongtrinh { get; set; }

        public int? idkhoahoc { get; set; }

        public DateTime? updatetime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? HP_full { get; set; }

        public int? sogio { get; set; }

        [StringLength(50)]
        public string block1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tkonline { get; set; }

        [StringLength(50)]
        public string block12 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tktestdauvao { get; set; }
    }
}
