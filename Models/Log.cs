namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Log
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        [StringLength(200)]
        public string logs { get; set; }

        public DateTime? thoigian { get; set; }
    }
}
