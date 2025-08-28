namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_ZipAddressCity
    {
        public int id { get; set; }

        [StringLength(1000)]
        public string address { get; set; }

        [StringLength(20)]
        public string zip { get; set; }

        [StringLength(200)]
        public string city { get; set; }

        [StringLength(20)]
        public string countryCode { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }
    }
}
