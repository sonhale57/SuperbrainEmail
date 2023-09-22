namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ketquan_style2_tb1
    {
        public int id { get; set; }

        public int? idketqua2 { get; set; }

        public int? type { get; set; }

        [StringLength(1500)]
        public string tenbaihoc { get; set; }

        [StringLength(1500)]
        public string thangdiem { get; set; }

        [StringLength(1500)]
        public string mucdo { get; set; }

        [StringLength(1500)]
        public string nhanxet { get; set; }
    }
}
