namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hocphi")]
    public partial class Hocphi
    {
        public int id { get; set; }

        public int? iddangkygroup { get; set; }

        public int? IDdangky { get; set; }

        public DateTime? Ngaythu { get; set; }

        public int? IDuser { get; set; }

        [StringLength(50)]
        public string MAHP { get; set; }

        public int? Type { get; set; }

        public DateTime? updatetime { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? thucthu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? thanhtoan { get; set; }

        [StringLength(500)]
        public string thanhtoan_text { get; set; }

        [Column(TypeName = "ntext")]
        public string ghichu { get; set; }

        [StringLength(50)]
        public string hinhthuc { get; set; }
    }
}
