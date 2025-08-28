namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblLog")]
    public partial class tblLog
    {
        public int id { get; set; }

        public int? severity { get; set; }

        [StringLength(4000)]
        public string message { get; set; }

        [StringLength(500)]
        public string methodName { get; set; }

        [StringLength(500)]
        public string bookmark { get; set; }

        [StringLength(1000)]
        public string freeField1 { get; set; }

        [StringLength(1000)]
        public string freeField2 { get; set; }

        public long? timestamp { get; set; }
    }
}
