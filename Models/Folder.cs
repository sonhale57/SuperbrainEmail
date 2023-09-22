namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Folder")]
    public partial class Folder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Folder()
        {
            Folder_FIles = new HashSet<Folder_FIles>();
        }

        public int id { get; set; }

        [StringLength(500)]
        public string ten { get; set; }

        [StringLength(1500)]
        public string mota { get; set; }

        public int? iduser { get; set; }

        public DateTime? updatetime { get; set; }

        public int? enable { get; set; }

        public int? share { get; set; }

        public int? permission { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Folder_FIles> Folder_FIles { get; set; }
    }
}
