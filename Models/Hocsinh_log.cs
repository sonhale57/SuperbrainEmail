namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hocsinh_log
    {
        public int id { get; set; }

        public int? idhocsinh { get; set; }

        public int? iduser { get; set; }

        [StringLength(500)]
        public string notes { get; set; }

        public DateTime? updatetime { get; set; }

        public DateTime? dateLog { get; set; }

        [Column("checked")]
        public int? _checked { get; set; }
    }
}
