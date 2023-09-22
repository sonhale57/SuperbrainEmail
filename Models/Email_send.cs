namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Email_send
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public DateTime? updatetime { get; set; }

        public int? idcat { get; set; }

        public int? status { get; set; }

        public int? idhocvien { get; set; }

        [StringLength(500)]
        public string namehv { get; set; }

        [StringLength(500)]
        public string email { get; set; }
    }
}
