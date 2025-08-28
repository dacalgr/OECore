namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblAudit")]
    public partial class tblAudit
    {
        public long id { get; set; }

        public string message { get; set; }

        [StringLength(50)]
        public string method { get; set; }

        [StringLength(50)]
        public string category { get; set; }

        [StringLength(15)]
        public string sqliteVersion { get; set; }

        [StringLength(100)]
        public string freeField1 { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? createdAt { get; set; }
    }
}
