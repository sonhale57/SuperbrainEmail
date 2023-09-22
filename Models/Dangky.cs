namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dangky")]
    public partial class Dangky
    {
        public int id { get; set; }

        public int? iddangkygroup { get; set; }

        [StringLength(50)]
        public string MADK { get; set; }

        public int? IDhocsinh { get; set; }

        public int? IDkhoahoc { get; set; }

        public int? idkhuyenmai { get; set; }

        public int? IDlop { get; set; }

        public int? Hocthu { get; set; }

        public double? Giam { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Hocphi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Phitailieu { get; set; }

        public int? IDuser { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Tonghocphi { get; set; }

        public DateTime? ngaydangky { get; set; }

        public DateTime? Updatetime { get; set; }

        [StringLength(1000)]
        public string HTTT { get; set; }

        [StringLength(1000)]
        public string ghichu { get; set; }

        public int? enable { get; set; }

        public int? idkhuyenmai_pass { get; set; }

        public int? status { get; set; }

        public int? Sendmail_kq { get; set; }

        public DateTime? date_modify { get; set; }

        public bool? status_chuyenkhoa { get; set; }
    }
}
