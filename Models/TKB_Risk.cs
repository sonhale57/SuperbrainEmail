namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TKB_Risk
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public DateTime? updatetime { get; set; }

        public DateTime? fromdate { get; set; }

        public DateTime? todate { get; set; }

        public int? idchiNhanh { get; set; }

        [StringLength(1500)]
        public string mota { get; set; }
    }
}
