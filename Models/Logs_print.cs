namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Logs_print
    {
        public int id { get; set; }

        public DateTime? date { get; set; }

        [Column(TypeName = "ntext")]
        public string contain { get; set; }

        public int? iduser { get; set; }
    }
}
