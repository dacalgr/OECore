namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_STATISTICS_Logins
    {
        public int id { get; set; }

        public int? userId { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(100)]
        public string device { get; set; }

        [StringLength(100)]
        public string appVersion { get; set; }

        [StringLength(100)]
        public string databaseVersion { get; set; }

        [StringLength(100)]
        public string eTicketAppVersion { get; set; }

        [StringLength(100)]
        public string eTicketDatabaseVersion { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? longitude { get; set; }

        [StringLength(15)]
        public string imei { get; set; }

        [StringLength(17)]
        public string mac { get; set; }

        [StringLength(4000)]
        public string name { get; set; }

        [StringLength(4000)]
        public string lastName { get; set; }

        [StringLength(50)]
        public string personalNumber { get; set; }

        [StringLength(50)]
        public string operation { get; set; }
    }
}
