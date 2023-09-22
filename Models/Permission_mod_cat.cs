namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permission_mod_cat
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public DateTime? updatetime { get; set; }

        public int? iduser { get; set; }

        [StringLength(50)]
        public string Ma { get; set; }

        public int? stt { get; set; }

        public int? enable { get; set; }

        [Column("public")]
        public bool? _public { get; set; }
    }
}
