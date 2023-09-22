namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hocsinh_CNKK
    {
        public int id { get; set; }

        public int? idhocvien { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(500)]
        public string tenkhoahoc { get; set; }

        public DateTime? todate { get; set; }

        [StringLength(50)]
        public string tongdiem { get; set; }

        public int? idcat { get; set; }

        public int? status { get; set; }
    }
}
