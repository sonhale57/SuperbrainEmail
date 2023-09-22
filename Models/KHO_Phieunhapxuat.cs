namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHO_Phieunhapxuat
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Maphieu { get; set; }

        public DateTime? Updatetime { get; set; }

        public int? iduser { get; set; }

        [StringLength(100)]
        public string hoten { get; set; }

        [StringLength(20)]
        public string dienthoai { get; set; }

        [StringLength(100)]
        public string diachi { get; set; }

        [StringLength(500)]
        public string lydo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tongtien { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? debit { get; set; }

        public int? type { get; set; }

        public int? idChinhanh { get; set; }

        public int? idncc { get; set; }
    }
}
