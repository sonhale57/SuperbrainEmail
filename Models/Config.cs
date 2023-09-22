namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Config")]
    public partial class Config
    {
        public int id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Phithuonghieu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Phitaikhoan { get; set; }

        public DateTime? Thoigiantinhphi { get; set; }
    }
}
