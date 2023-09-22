namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class taisan_cat
    {
        public int id { get; set; }

        public int iduser { get; set; }

        [StringLength(50)]
        public string Maloai { get; set; }

        [StringLength(100)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string diengiai { get; set; }

        public int? idChiNhanh { get; set; }

        public int? enable { get; set; }
    }
}
