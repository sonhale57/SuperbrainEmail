namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permission_Template
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? iduser { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? idmod { get; set; }

        public int? per_r { get; set; }

        public int? per_w { get; set; }

        public DateTime? updatetime { get; set; }
    }
}
