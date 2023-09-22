namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Kho_Head
    {
        public int idsanpham { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Soluong { get; set; }

        public DateTime? dateup { get; set; }

        public int iduser { get; set; }

        public int id { get; set; }

        public virtual Donhang_setting Donhang_setting { get; set; }
    }
}
