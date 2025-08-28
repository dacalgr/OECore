namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_login_statistics
    {
        [StringLength(50)]
        public string personalNumber { get; set; }

        [StringLength(4000)]
        public string name { get; set; }

        [StringLength(4000)]
        public string lastName { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(100)]
        public string device { get; set; }

        [StringLength(100)]
        public string appVersion { get; set; }

        [StringLength(100)]
        public string databaseVersion { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(15)]
        public string imei { get; set; }

        [StringLength(17)]
        public string mac { get; set; }
    }
}
