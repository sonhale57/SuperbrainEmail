namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class KHOADAOTAO_Thanhtoanphi
    {
        public int id { get; set; }

        public int? idUser { get; set; }

        public int? idChinhanh { get; set; }

        public int? idKhoadaotao { get; set; }

        public int? soluong { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tongtien { get; set; }

        public DateTime? updatetime { get; set; }

        [Column(TypeName = "ntext")]
        public string image { get; set; }

        [StringLength(500)]
        public string ghichu { get; set; }
    }
}
