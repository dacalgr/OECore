namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_BACKUP_Regions
    {
        public int id { get; set; }

        public int regionId { get; set; }

        [StringLength(100)]
        public string shortName { get; set; }

        [StringLength(500)]
        public string name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        public int? inmodo_TCID { get; set; }

        public int? voevCode { get; set; }

        public DateTime? dtLastSQLIteImport { get; set; }
    }
}
