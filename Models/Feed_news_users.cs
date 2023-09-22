namespace SuperbrainEmail.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Feed_news_users
    {
        public int id { get; set; }

        public int? idchinhanh { get; set; }

        public int? idfeed { get; set; }

        public DateTime? updatetime { get; set; }

        public int? readed { get; set; }

        public virtual Feed_news Feed_news { get; set; }
    }
}
