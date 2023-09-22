namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Task")]
    public partial class Task
    {
        public int id { get; set; }

        public int? type { get; set; }

        [Column(TypeName = "ntext")]
        public string noidung { get; set; }

        public DateTime? ngay { get; set; }

        public int? iduser { get; set; }

        public int? enable { get; set; }

        public int? idhocvien { get; set; }

        public int? IDrelation { get; set; }
    }
}
