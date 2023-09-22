namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Giaovien_Taphuan
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idKhoa_taphuan { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idgiaovien { get; set; }

        public int? Trangthai { get; set; }

        [StringLength(150)]
        public string GhiChu { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateDK { get; set; }

        public int? idUser { get; set; }

        public int? isPass { get; set; }

        public int? idChiNhanh { get; set; }

        public int? Dangkyluutru { get; set; }
    }
}
