namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_lastSynchronization
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long rowNumber { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int userId { get; set; }

        [StringLength(50)]
        public string personalNumber { get; set; }

        [StringLength(4000)]
        public string name { get; set; }

        [StringLength(4000)]
        public string lastName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? timestamp { get; set; }

        [StringLength(100)]
        public string device { get; set; }

        [StringLength(15)]
        public string imei { get; set; }

        [StringLength(17)]
        public string mac { get; set; }

        [StringLength(100)]
        public string appVersion { get; set; }

        [StringLength(100)]
        public string databaseVersion { get; set; }

        public int? id { get; set; }

        [StringLength(100)]
        public string type { get; set; }

        public Guid? itemGUID { get; set; }
    }
}
