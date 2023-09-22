namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiNhanh")]
    public partial class ChiNhanh
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChiNhanh()
        {
            Notifications = new HashSet<Notification>();
            Thongke_Head = new HashSet<Thongke_Head>();
            Email_Cat = new HashSet<Email_Cat>();
        }

        public int id { get; set; }

        public DateTime? updatetime { get; set; }

        public int? iduser { get; set; }

        [StringLength(500)]
        public string logo { get; set; }

        [StringLength(10)]
        public string thongtin_block1 { get; set; }

        [StringLength(500)]
        public string Machinhanh { get; set; }

        [StringLength(1500)]
        public string Ten { get; set; }

        public bool? enable { get; set; }

        [StringLength(500)]
        public string tencongty { get; set; }

        [StringLength(500)]
        public string diachi { get; set; }

        [StringLength(500)]
        public string tinh { get; set; }

        [StringLength(500)]
        public string map { get; set; }

        [StringLength(500)]
        public string dienthoai { get; set; }

        [StringLength(500)]
        public string email { get; set; }

        [StringLength(500)]
        public string mst { get; set; }

        [StringLength(500)]
        public string giayphepgiaoduc { get; set; }

        [StringLength(10)]
        public string caidat_block { get; set; }

        public int? limituser { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? soluonglop { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? testdauvao { get; set; }

        [StringLength(50)]
        public string SMS { get; set; }

        [Column(TypeName = "ntext")]
        public string diengiai { get; set; }

        [StringLength(500)]
        public string dcgiaohang { get; set; }

        [StringLength(50)]
        public string phonegiaohang { get; set; }

        public int? uudai { get; set; }

        public DateTime? fromdate { get; set; }

        public DateTime? todate { get; set; }

        public DateTime DateExpire { get; set; }

        public bool? Active { get; set; }

        [StringLength(500)]
        public string email1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? chiphi { get; set; }

        public int? groupchiphi { get; set; }

        public DateTime? hanhopdong { get; set; }

        [StringLength(50)]
        public string sohopdong { get; set; }

        public DateTime DateTKOnline { get; set; }

        [StringLength(50)]
        public string lienheThiTQ { get; set; }

        [StringLength(50)]
        public string dienthoaiThiTQ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Thongke_Head> Thongke_Head { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Email_Cat> Email_Cat { get; set; }
    }
}
