namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permission_join
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? idmod { get; set; }

        public int? idtemplate { get; set; }

        public int? lever { get; set; }

        public DateTime? updatetime { get; set; }

        public int? permision { get; set; }

        public int? per_r { get; set; }

        public int? per_a { get; set; }

        public int? per_e { get; set; }

        public int? per_w { get; set; }

        public int? idcreate { get; set; }
    }
}
