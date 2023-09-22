namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemDanh")]
    public partial class DiemDanh
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? idThisinh { get; set; }

        [StringLength(50)]
        public string khuvuc { get; set; }

        public int? year { get; set; }

        public int? updatetime { get; set; }

        public int? idUser { get; set; }

        public int? Trangthai { get; set; }
    }
}
