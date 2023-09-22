namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Thanhtoan_taphuan
    {
        public int? soluong { get; set; }

        public int idChiNhanh { get; set; }

        public int idedit { get; set; }

        public int? Trangthai { get; set; }

        [StringLength(500)]
        public string image { get; set; }

        public int? iduser { get; set; }

        [StringLength(500)]
        public string Ghichu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? phi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dateup { get; set; }

        public int id { get; set; }
    }
}
