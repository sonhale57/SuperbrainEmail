namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Khoahoc_kho
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? idchinhanh { get; set; }

        public int? idkhoahoc { get; set; }

        public int? idtaisan { get; set; }

        public int? soluong { get; set; }

        public DateTime? updatetime { get; set; }
    }
}
