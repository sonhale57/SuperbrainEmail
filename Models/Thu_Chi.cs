namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Thu_Chi
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? iddangkygroup { get; set; }

        public int? status { get; set; }

        public int? idchinhanh { get; set; }

        [StringLength(50)]
        public string MAPT { get; set; }

        public DateTime? updatetime { get; set; }

        public DateTime? dateCreate { get; set; }

        public DateTime? ngay { get; set; }

        public int? type { get; set; }

        [StringLength(500)]
        public string nguoinoptien { get; set; }

        [StringLength(500)]
        public string diachi { get; set; }

        [StringLength(2500)]
        public string lydo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tongtien { get; set; }

        [StringLength(500)]
        public string bangchu { get; set; }

        [StringLength(500)]
        public string sochungtu { get; set; }

        [StringLength(1500)]
        public string ghichu { get; set; }

        public int? Loai { get; set; }
    }
}
