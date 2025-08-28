namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_CleanJobsConfiguration
    {
        public int id { get; set; }

        [StringLength(50)]
        public string days { get; set; }

        public bool monthly { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? lastExecution { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? nextExecution { get; set; }
    }
}
