namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Giao_vien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Giao_vien()
        {
            Nhansu_ChamCong = new HashSet<Nhansu_ChamCong>();
            Nhansu_ghichu = new HashSet<Nhansu_ghichu>();
        }

        public int id { get; set; }

        public int? iduser { get; set; }

        public DateTime? Updatetime { get; set; }

        [StringLength(20)]
        public string Makhachhang { get; set; }

        [StringLength(100)]
        public string Hoten { get; set; }

        [StringLength(150)]
        public string Diachi { get; set; }

        [StringLength(18)]
        public string Mst { get; set; }

        [StringLength(50)]
        public string Dienthoai { get; set; }

        [StringLength(100)]
        public string Ghichu { get; set; }

        public bool? KH_caNhan { get; set; }

        public bool? KH_congty { get; set; }

        public bool? KH_nhanvien { get; set; }

        public bool? enable { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? congno { get; set; }

        public int? danhdau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nhansu_ChamCong> Nhansu_ChamCong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Nhansu_ghichu> Nhansu_ghichu { get; set; }
    }
}
