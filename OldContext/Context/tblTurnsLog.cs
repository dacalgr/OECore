namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTurnsLog")]
    public partial class tblTurnsLog
    {
        public int id { get; set; }

        [StringLength(4000)]
        public string turnFields { get; set; }

        [StringLength(10)]
        public string operation { get; set; }

        public Guid? turnId { get; set; }

        [StringLength(10)]
        public string appVersion { get; set; }

        [StringLength(400)]
        public string deviceId { get; set; }

        [StringLength(50)]
        public string sqliteVersion { get; set; }

        public DateTime date { get; set; }

        [StringLength(50)]
        public string sqliteLastUpdate { get; set; }

        [StringLength(400)]
        public string imei { get; set; }
    }
}
