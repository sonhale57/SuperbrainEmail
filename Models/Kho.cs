namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kho")]
    public partial class Kho
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idvattu { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idChiNhanh { get; set; }

        [StringLength(50)]
        public string donvi { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dongia { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? tonkho { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? dinhmuc { get; set; }

        public int? enable { get; set; }
    }
}
