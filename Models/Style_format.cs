namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Style_format
    {
        public int id { get; set; }

        [StringLength(50)]
        public string ten { get; set; }

        public int? type { get; set; }

        [StringLength(50)]
        public string module { get; set; }
    }
}
