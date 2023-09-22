namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Test_auto
    {
        public int id { get; set; }

        [StringLength(50)]
        public string textbox { get; set; }

        [StringLength(50)]
        public string Selectoption { get; set; }

        [StringLength(50)]
        public string Checkbox { get; set; }

        [StringLength(10)]
        public string radiobox { get; set; }

        [StringLength(50)]
        public string SL2 { get; set; }

        [StringLength(10)]
        public string file1 { get; set; }

        [StringLength(50)]
        public string groupblock { get; set; }

        public DateTime? datetime { get; set; }

        [StringLength(50)]
        public string hidden { get; set; }
    }
}
