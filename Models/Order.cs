namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public int? IdChinhanh { get; set; }

        public int? Iduser { get; set; }

        public int? Status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tongtien { get; set; }

        public DateTime? Updatetime { get; set; }

        [StringLength(500)]
        public string Ghichu { get; set; }

        [StringLength(500)]
        public string diachi { get; set; }

        [StringLength(20)]
        public string dienthoai { get; set; }
    }
}
