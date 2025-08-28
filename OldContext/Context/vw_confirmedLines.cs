namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_confirmedLines
    {
        [Column(Order = 0)]
        public Guid id { get; set; }

        [StringLength(50)]
        public string personalNumber { get; set; }

        [StringLength(50)]
        public string route { get; set; }

        [StringLength(4000)]
        public string confirmedLineReason { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? startTime { get; set; }

        public bool? confirmedline { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int companyId { get; set; }

        [StringLength(50)]
        public string shortName { get; set; }

        [StringLength(512)]
        public string name { get; set; }

        [StringLength(4000)]
        public string station { get; set; }

        [StringLength(50)]
        public string zone { get; set; }
    }
}
