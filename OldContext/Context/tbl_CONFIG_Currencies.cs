namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Currencies
    {
        public int id { get; set; }

        [StringLength(8)]
        public string code { get; set; }

        [StringLength(8)]
        public string currency { get; set; }

        public float factor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }
    }
}
