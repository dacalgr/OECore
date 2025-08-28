namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DEBUG_RequestTimeCheck
    {
        public int id { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(512)]
        public string requestedResource { get; set; }

        public string queryString { get; set; }

        public string headers { get; set; }

        public string requestBody { get; set; }

        public string responseBody { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime startTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime endTime { get; set; }

        public double totalSeconds { get; set; }
    }
}
