namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ketqua_style1
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
        public string nghe { get; set; }

        [StringLength(500)]
        public string nhin { get; set; }

        [StringLength(500)]
        public string tocky { get; set; }

        [StringLength(500)]
        public string online { get; set; }

        [StringLength(500)]
        public string tongdiem { get; set; }

        [StringLength(500)]
        public string taptrung_block { get; set; }

        [StringLength(500)]
        public string taptrung_datduoc { get; set; }

        [StringLength(500)]
        public string taptrung_caithien { get; set; }

        [StringLength(500)]
        public string tutin_block { get; set; }

        [StringLength(500)]
        public string tutin_datduoc { get; set; }

        [StringLength(500)]
        public string tutin_caithien { get; set; }

        [StringLength(500)]
        public string nho_block { get; set; }

        [StringLength(500)]
        public string nho_datduoc { get; set; }

        [StringLength(500)]
        public string nho_caithien { get; set; }

        [StringLength(500)]
        public string phanxa_block { get; set; }

        [StringLength(500)]
        public string phanxa_datduoc { get; set; }

        [StringLength(500)]
        public string phanxa_caithien { get; set; }

        [StringLength(500)]
        public string nhanxetchung { get; set; }

        [StringLength(500)]
        public string dinhhuongkhoatiep { get; set; }
    }
}
