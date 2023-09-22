namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notification")]
    public partial class Notification
    {
        public int id { get; set; }

        public DateTime? dateup { get; set; }

        public int? enable { get; set; }

        [StringLength(500)]
        public string content { get; set; }

        [StringLength(250)]
        public string title { get; set; }

        public int? toChiNhanh { get; set; }

        public int? idUser { get; set; }

        [StringLength(250)]
        public string link { get; set; }

        public int? type { get; set; }

        public int? value { get; set; }

        public virtual ChiNhanh ChiNhanh { get; set; }
    }
}
