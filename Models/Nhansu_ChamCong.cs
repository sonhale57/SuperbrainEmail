namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nhansu_ChamCong
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? idnhansu { get; set; }

        public DateTime? Update_Time { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Diem { get; set; }

        public virtual Giao_vien Giao_vien { get; set; }
    }
}
