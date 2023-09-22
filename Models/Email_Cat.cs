namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Email_Cat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Email_Cat()
        {
            ChiNhanhs = new HashSet<ChiNhanh>();
        }

        public int id { get; set; }

        public int? type { get; set; }

        public int? iduser { get; set; }

        [StringLength(2000)]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string noidung { get; set; }

        public DateTime? updatetime { get; set; }

        public int? enable { get; set; }

        [StringLength(500)]
        public string cat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiNhanh> ChiNhanhs { get; set; }
    }
}
