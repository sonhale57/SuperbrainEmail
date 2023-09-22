namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Thanhtoan_User
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? idChinhanh { get; set; }

        public DateTime? updatetime { get; set; }

        public int? month { get; set; }

        public int? soluong { get; set; }

        public int? status { get; set; }

        [StringLength(250)]
        public string image { get; set; }

        [StringLength(250)]
        public string Ghichu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tongtien { get; set; }

        public int? type { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? uudai { get; set; }
    }
}
