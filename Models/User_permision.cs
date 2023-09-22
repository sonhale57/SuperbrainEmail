namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_permision
    {
        public int id { get; set; }

        public int? iduser { get; set; }

        public int? idmodule { get; set; }

        public virtual Users_module Users_module { get; set; }
    }
}
