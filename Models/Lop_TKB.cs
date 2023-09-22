namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lop_TKB
    {
        public int id { get; set; }

        public int? idweek { get; set; }

        public int? idlop { get; set; }

        public int? iduser { get; set; }

        public DateTime? fromdate { get; set; }

        public DateTime? todate { get; set; }

        public int? idgiaovien { get; set; }

        public int? idphonghoc { get; set; }
    }
}
