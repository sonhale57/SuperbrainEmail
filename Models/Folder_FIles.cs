namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Folder_FIles
    {
        public int ID { get; set; }

        public int? idfolder { get; set; }

        public int? iduser { get; set; }

        [StringLength(500)]
        public string ten { get; set; }

        [StringLength(500)]
        public string mota { get; set; }

        public int? filesize { get; set; }

        [StringLength(500)]
        public string typefile { get; set; }

        public DateTime? updatetime { get; set; }

        [StringLength(500)]
        public string store { get; set; }

        [StringLength(1500)]
        public string link { get; set; }

        public int? type { get; set; }

        public virtual Folder Folder { get; set; }
    }
}
