namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NCC")]
    public partial class NCC
    {
        public int id { get; set; }

        [StringLength(150)]
        public string Ten { get; set; }

        [StringLength(50)]
        public string SDT { get; set; }

        [StringLength(250)]
        public string Diachi { get; set; }

        [StringLength(50)]
        public string MST { get; set; }

        public int? idChinhanh { get; set; }
    }
}
