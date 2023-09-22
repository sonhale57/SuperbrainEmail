namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hocsinh_voucher
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? idhocsinh { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? voucher { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(1500)]
        public string mota { get; set; }
    }
}
