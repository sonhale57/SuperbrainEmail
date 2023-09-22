namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Donhang_setting
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donhang_setting()
        {
            Kho_Head = new HashSet<Kho_Head>();
        }

        public int id { get; set; }

        public int? iduser { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(500)]
        public string images { get; set; }

        [StringLength(1500)]
        public string name { get; set; }

        [StringLength(50)]
        public string donvi { get; set; }

        [StringLength(1500)]
        public string ghichu { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongia1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? soluong1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongia2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? soluong2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongia3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? soluong3 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tonkho { get; set; }

        public int? heso { get; set; }

        public int? enable { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dinhmuc { get; set; }

        [StringLength(150)]
        public string donvicoso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongiacoso { get; set; }

        public int? type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kho_Head> Kho_Head { get; set; }
    }
}
