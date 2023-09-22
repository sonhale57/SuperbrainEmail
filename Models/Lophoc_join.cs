namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lophoc_join
    {
        public int id { get; set; }

        public int? idhocvien { get; set; }

        public int? iddangky { get; set; }

        public int? idlop { get; set; }

        public DateTime? updatetime { get; set; }

        public DateTime? fromdate { get; set; }

        public DateTime? todate { get; set; }

        public int? idkhoahoc { get; set; }

        public int? sobuoi { get; set; }

        public DateTime? todate_temp { get; set; }

        public DateTime? fromdate_temp { get; set; }
    }
}
