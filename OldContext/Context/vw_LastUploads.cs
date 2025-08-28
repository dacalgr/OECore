namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_LastUploads
    {
        [StringLength(50)]
        public string personalNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Date { get; set; }

        [Key]
        [StringLength(8)]
        public string Type { get; set; }
    }
}
