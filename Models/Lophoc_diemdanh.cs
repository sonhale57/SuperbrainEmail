namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lophoc_diemdanh
    {
        public int id { get; set; }

        public int? idlop { get; set; }

        public int? idjoint { get; set; }

        public int? idhocvien { get; set; }

        [StringLength(500)]
        public string notes { get; set; }

        public DateTime? updatetime { get; set; }

        public int? iduser { get; set; }

        public int? enable { get; set; }

        public DateTime? ngay { get; set; }
    }
}
