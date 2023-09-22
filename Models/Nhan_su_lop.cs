namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Nhan_su_lop
    {
        public int id { get; set; }

        public int? idgiaovien { get; set; }

        [StringLength(10)]
        public string idlop { get; set; }
    }
}
