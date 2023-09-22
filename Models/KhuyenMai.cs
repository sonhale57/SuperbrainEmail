namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        public int id { get; set; }

        [StringLength(50)]
        public string makm { get; set; }

        [StringLength(2000)]
        public string notes { get; set; }

        public DateTime? ngaybatdau { get; set; }

        public DateTime? ngayketthuc { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? giatri { get; set; }

        public int? enable { get; set; }

        public int? idtaisan { get; set; }

        public int? soluong { get; set; }

        public int? idchinhanh { get; set; }
    }
}
