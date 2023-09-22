namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hocsinh_CNKK_cat
    {
        public int id { get; set; }

        public int? idchinhanh { get; set; }

        public int? iduser { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(500)]
        public string name { get; set; }
    }
}
