namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblBlacklistStaging")]
    public partial class tblBlacklistStaging
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string vorname { get; set; }

        public bool? blacklisted { get; set; }

        [StringLength(1024)]
        public string comments_de { get; set; }

        [StringLength(1024)]
        public string comments_fr { get; set; }

        [StringLength(1024)]
        public string comments_it { get; set; }

        public long? birthdate { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long created { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? expirationDate { get; set; }

        [StringLength(2014)]
        public string comments { get; set; }

        public int? fileId { get; set; }
    }
}
