namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tbl_MONITOR_Data")]
    public partial class tbl_MONITOR_Data
    {
        public int id { get; set; }

        [StringLength(4000)]
        public string message { get; set; }

        [StringLength(500)]
        public string type { get; set; }

        [StringLength(500)]
        public string subType { get; set; }

        [StringLength(1000)]
        public string cathegory { get; set; }

        [StringLength(1000)]
        public string subCathegory { get; set; }

        [StringLength(100)]
        public string result { get; set; }

        public DateTime timestamp { get; set; }
    }
}
