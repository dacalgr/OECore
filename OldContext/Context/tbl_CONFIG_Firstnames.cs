namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Firstnames
    {
        public int id { get; set; }

        [StringLength(16)]
        public string gender { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(32)]
        public string name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }
    }
}
