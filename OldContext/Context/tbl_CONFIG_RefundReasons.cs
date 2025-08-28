namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_RefundReasons
    {
        public int id { get; set; }

        [StringLength(512)]
        public string text_de { get; set; }

        [StringLength(512)]
        public string text_fr { get; set; }

        [StringLength(512)]
        public string text_it { get; set; }

        [StringLength(512)]
        public string langRef { get; set; }

        public int? rank { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }
    }
}
