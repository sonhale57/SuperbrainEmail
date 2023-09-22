namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nhansu_Log
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public DateTime? dateup { get; set; }

        [StringLength(4000)]
        public string notes { get; set; }

        public int? status { get; set; }

        public int? idChinhanh { get; set; }

        public int? idhocvien { get; set; }

        [StringLength(50)]
        public string type { get; set; }
    }
}
