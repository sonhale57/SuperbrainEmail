namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        public int? idnhansu { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string inputuser { get; set; }

        [StringLength(100)]
        public string inputpass { get; set; }

        public int? enable { get; set; }

        public int? lever { get; set; }

        [StringLength(50)]
        public string hoten { get; set; }

        public DateTime? updatetime { get; set; }

        public int? idChiNhanh { get; set; }

        [StringLength(500)]
        public string ghichu { get; set; }

        public DateTime? dateline { get; set; }

        public DateTime? lastlogin { get; set; }

        public bool active { get; set; }

        public DateTime exp { get; set; }

        public virtual User Users1 { get; set; }

        public virtual User User1 { get; set; }
    }
}
