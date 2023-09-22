namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHO_Vattu
    {
        public int id { get; set; }

        [StringLength(200)]
        public string ten { get; set; }

        [StringLength(200)]
        public string mota { get; set; }

        [StringLength(2000)]
        public string image { get; set; }

        [StringLength(200)]
        public string donvi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongia { get; set; }

        public int? tonkho { get; set; }

        public int? dinhmuc { get; set; }

        public int? idChiNhanh { get; set; }

        public int? enable { get; set; }

        public int? idUser { get; set; }

        public DateTime? updatetime { get; set; }
    }
}
