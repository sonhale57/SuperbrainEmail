namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Donhang_cat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Donhang_cat()
        {
            Trangthai_donhang = new HashSet<Trangthai_donhang>();
        }

        public int? iduser { get; set; }

        public int? idchinhanh { get; set; }

        public int? status_dh { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(1500)]
        public string ghichu { get; set; }

        public int id { get; set; }

        public int? status { get; set; }

        public int? enable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trangthai_donhang> Trangthai_donhang { get; set; }
    }
}
