namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Folder_users
    {
        public int id { get; set; }

        public int? idfolder { get; set; }

        public int? idchinhanh { get; set; }

        public DateTime? updatetime { get; set; }
    }
}
