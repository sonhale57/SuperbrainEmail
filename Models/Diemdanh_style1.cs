namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Diemdanh_style1
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? idgiaovien { get; set; }

        public int? idhocsinh { get; set; }

        public int? iddangky { get; set; }

        public int? idlop { get; set; }

        [Column("checked")]
        public int? _checked { get; set; }

        public DateTime? ngay { get; set; }

        public int? enable { get; set; }

        [StringLength(1000)]
        public string baihoc { get; set; }

        [StringLength(10)]
        public string nhanxet_block { get; set; }

        [StringLength(500)]
        public string tuduylogic { get; set; }

        [StringLength(500)]
        public string toiuubaitoan { get; set; }

        [StringLength(500)]
        public string xulyvande { get; set; }

        [StringLength(500)]
        public string bieudatngonngu { get; set; }

        [StringLength(500)]
        public string khac { get; set; }

        [StringLength(500)]
        public string Power { get; set; }

        [StringLength(500)]
        public string sendsms { get; set; }
    }
}
