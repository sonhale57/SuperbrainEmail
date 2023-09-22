namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ketqua_style2
    {
        public int id { get; set; }

        public int? emailSend { get; set; }

        public int? iduser { get; set; }

        public int? idgiaovien { get; set; }

        public int? idhocsinh { get; set; }

        public int? iddangky { get; set; }

        public int? idlop { get; set; }

        public DateTime? updatetime { get; set; }

        public DateTime? ngay { get; set; }

        [StringLength(500)]
        public string type { get; set; }

        [StringLength(500)]
        public string bangdiem_block { get; set; }

        [StringLength(500)]
        public string nhanxetchung { get; set; }
    }
}
