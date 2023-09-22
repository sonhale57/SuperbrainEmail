namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nhansu_ghichu
    {
        public int id { get; set; }

        public int? idnhansu { get; set; }

        [StringLength(200)]
        public string ghichu { get; set; }

        public DateTime? ngay { get; set; }

        public DateTime? update_time { get; set; }

        public int? iduser { get; set; }

        public virtual Giao_vien Giao_vien { get; set; }
    }
}
