namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Thongke_Head
    {
        public int id { get; set; }

        public int? idsanpham { get; set; }

        public DateTime? dateup { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tonkho { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? soluong { get; set; }

        public int? type { get; set; }

        public int? idChiNhanh { get; set; }

        public int? iduser { get; set; }

        [StringLength(500)]
        public string ghichu { get; set; }

        public int? iddonhang { get; set; }

        public virtual ChiNhanh ChiNhanh { get; set; }
    }
}
