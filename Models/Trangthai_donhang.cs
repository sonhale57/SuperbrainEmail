namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trangthai_donhang
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int iddonhang { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int trangthai { get; set; }

        public DateTime? dateup { get; set; }

        [StringLength(500)]
        public string Ghichu { get; set; }

        [StringLength(500)]
        public string Hinhanh { get; set; }

        public virtual Donhang_cat Donhang_cat { get; set; }
    }
}
