namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Dangky_group
    {
        public int id { get; set; }

        [StringLength(50)]
        public string madk { get; set; }

        public int? idhocsinh { get; set; }

        public DateTime? updatetime { get; set; }

        public int? iduser { get; set; }

        public int? status { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tongtien { get; set; }

        public int? idchinhanh { get; set; }

        [StringLength(1000)]
        public string ghichu { get; set; }

        public int? enable { get; set; }

        [StringLength(150)]
        public string tenkh { get; set; }

        public int? type { get; set; }

        public int? ncc { get; set; }

        public int? Xuatkho { get; set; }
    }
}
