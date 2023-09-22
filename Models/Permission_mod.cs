namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permission_mod
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Ma { get; set; }

        public int? idcat { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? iduser { get; set; }

        public DateTime? updatetime { get; set; }

        public int? enable { get; set; }

        [StringLength(500)]
        public string R_note { get; set; }

        [StringLength(500)]
        public string W_note { get; set; }
    }
}
