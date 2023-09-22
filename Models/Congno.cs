namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Congno")]
    public partial class Congno
    {
        public int id { get; set; }

        public DateTime? updatetime { get; set; }

        public int? iduser { get; set; }

        public int? idChiNhanh { get; set; }

        public int? type { get; set; }

        [StringLength(50)]
        public string Loai { get; set; }

        public int? idNCC { get; set; }

        public int? idhocvien { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tongtien { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? thanhtoan { get; set; }

        public int? status { get; set; }

        public int? idphieudangky { get; set; }

        public DateTime? ngayhen { get; set; }

        [StringLength(1000)]
        public string lydo { get; set; }
    }
}
