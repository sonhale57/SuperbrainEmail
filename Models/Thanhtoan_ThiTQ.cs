namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Thanhtoan_ThiTQ
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(1000)]
        public string image { get; set; }

        public int? soluong { get; set; }

        public double? tongtien { get; set; }

        public int? idChinhanh { get; set; }
    }
}
