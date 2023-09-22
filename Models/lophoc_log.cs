namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class lophoc_log
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? idlop { get; set; }

        public int? count { get; set; }

        public DateTime? updatetime { get; set; }

        public int? id_tkb { get; set; }

        public DateTime? fromdate { get; set; }

        public DateTime? todate { get; set; }
    }
}
