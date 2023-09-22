namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Config_data_text
    {
        public int id { get; set; }

        [StringLength(1000)]
        public string ten { get; set; }

        public int? type { get; set; }

        public int? value { get; set; }

        public int? orders { get; set; }

        public int? idChinhanh { get; set; }
    }
}
