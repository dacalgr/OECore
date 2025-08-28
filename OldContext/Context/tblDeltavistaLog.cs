namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblDeltavistaLog")]
    public partial class tblDeltavistaLog
    {
        public int id { get; set; }

        public int? status { get; set; }

        public int? error { get; set; }

        public string error_message { get; set; }

        [StringLength(50)]
        public string userId { get; set; }

        [StringLength(50)]
        public string incident { get; set; }

        public DateTime? timestamp { get; set; }
    }
}
