namespace WindowsAppPubs.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pub_info
    {
        [Key]
        [StringLength(4)]
        public string pub_id { get; set; }

        [Column(TypeName = "image")]
        public byte[] logo { get; set; }

        [Column(TypeName = "text")]
        public string pr_info { get; set; }

        public virtual Publisher publisher { get; set; }
    }
}
