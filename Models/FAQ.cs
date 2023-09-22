namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FAQ")]
    public partial class FAQ
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Danhmuc { get; set; }

        [Column(TypeName = "text")]
        public string Mota { get; set; }

        public DateTime? dateup { get; set; }

        public int? iduser { get; set; }

        [StringLength(250)]
        public string Tieude { get; set; }

        public int? Loai { get; set; }

        [StringLength(500)]
        public string hinhanh { get; set; }
    }
}
