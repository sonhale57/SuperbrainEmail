namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Diemdanh_style2
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? idhocsinh { get; set; }

        public int? idgiaovien { get; set; }

        public int? iddangky { get; set; }

        public int? enable { get; set; }

        public int? idlop { get; set; }

        [Column("checked")]
        public int? _checked { get; set; }

        public DateTime? ngay { get; set; }

        [StringLength(1000)]
        public string baihoc { get; set; }

        [StringLength(500)]
        public string btvn_block { get; set; }

        [StringLength(500)]
        public string hoanthanh { get; set; }

        [StringLength(500)]
        public string chinhxac { get; set; }

        [StringLength(500)]
        public string luyentaponline_block { get; set; }

        [StringLength(500)]
        public string trenlop_block { get; set; }

        [StringLength(500)]
        public string onha_block { get; set; }

        [StringLength(500)]
        public string trenlop_chuso { get; set; }

        [StringLength(500)]
        public string onha_hoanthanh { get; set; }

        [StringLength(500)]
        public string trenlop_hang { get; set; }

        [StringLength(500)]
        public string onha_chinhxac { get; set; }

        [StringLength(500)]
        public string trenlop_giay { get; set; }

        [StringLength(500)]
        public string nhanxet_block { get; set; }

        [StringLength(500)]
        public string kynang_block { get; set; }

        [StringLength(500)]
        public string taptrung { get; set; }

        [StringLength(500)]
        public string tutin { get; set; }

        [StringLength(500)]
        public string ghinho { get; set; }

        [StringLength(500)]
        public string phanxa { get; set; }

        [StringLength(500)]
        public string khac { get; set; }

        [StringLength(500)]
        public string Power { get; set; }

        [StringLength(500)]
        public string sendsms { get; set; }
    }
}
