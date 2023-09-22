namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Bangdiem")]
    public partial class Bangdiem
    {
        public int id { get; set; }

        [StringLength(10)]
        public string idhocsinh { get; set; }

        [StringLength(10)]
        public string idlop { get; set; }

        [StringLength(10)]
        public string diem { get; set; }
    }
}
