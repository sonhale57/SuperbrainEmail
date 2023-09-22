namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThiTQ")]
    public partial class ThiTQ
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        public int? idhocvien { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int year { get; set; }

        [StringLength(50)]
        public string sbd { get; set; }

        [Key]
        [Column(Order = 2)]
        public double diem1 { get; set; }

        [Key]
        [Column(Order = 3)]
        public double diem2 { get; set; }

        [Key]
        [Column(Order = 4)]
        public double diem3 { get; set; }

        [Key]
        [Column(Order = 5)]
        public double diem4 { get; set; }

        [Key]
        [Column(Order = 6)]
        public double diem5 { get; set; }

        [Key]
        [Column(Order = 7)]
        public double diem6 { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime updatetime { get; set; }

        [Key]
        [Column(Order = 9)]
        public byte capdo { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(50)]
        public string khuvuc { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(50)]
        public string ten { get; set; }

        public DateTime? namsinh { get; set; }

        [StringLength(50)]
        public string machinhanh { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int enable { get; set; }

        [StringLength(500)]
        public string sizeao { get; set; }

        public int? idChinhanh { get; set; }

        [StringLength(100)]
        public string vitringoi { get; set; }

        [StringLength(50)]
        public string bangthi { get; set; }

        public int? diemdanh { get; set; }

        public int? iddangkygroup { get; set; }

        public bool? checkin { get; set; }

        public DateTime? timecheckin { get; set; }

        public int? usercheckin { get; set; }

        public string Qrcode { get; set; }

        public string Qrcodevalue { get; set; }

        public bool? Confirmed { get; set; }

        [StringLength(500)]
        public string Ghichu { get; set; }
    }
}
