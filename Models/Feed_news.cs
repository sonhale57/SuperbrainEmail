namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Feed_news
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Feed_news()
        {
            Feed_news_users = new HashSet<Feed_news_users>();
        }

        public int id { get; set; }

        public int? iduser { get; set; }

        [StringLength(1500)]
        public string name { get; set; }

        [Column(TypeName = "ntext")]
        public string notes { get; set; }

        public DateTime? todate { get; set; }

        public int? type { get; set; }

        public DateTime? updatetime { get; set; }

        public int? idchinhanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Feed_news_users> Feed_news_users { get; set; }
    }
}
