namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongHoc")]
    public partial class PhongHoc
    {
        public int id { get; set; }

        public int? idchinhanh { get; set; }

        [StringLength(500)]
        public string ten { get; set; }

        [StringLength(1500)]
        public string mota { get; set; }

        public DateTime? updatetime { get; set; }

        public int? enable { get; set; }

        public int? iduser { get; set; }
    }
}
