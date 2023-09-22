namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHO_Chitietphieu
    {
        public long id { get; set; }

        public int? idphieu { get; set; }

        public int? iduser { get; set; }

        public DateTime? updatetime { get; set; }

        public int? idChinhanh { get; set; }

        public int? type { get; set; }

        public int? idvattu { get; set; }

        public int? soluong { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongia { get; set; }

        [StringLength(50)]
        public string donvi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? thanhtien { get; set; }

        [StringLength(50)]
        public string ghichu { get; set; }

        public int? iddonhang { get; set; }

        public int? idphieudangky { get; set; }

        public int? status { get; set; }
    }
}
