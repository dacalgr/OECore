namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTaskType1
    {
        public int id { get; set; }

        public int? taskTypeId { get; set; }

        public int? teamId { get; set; }

        [StringLength(4000)]
        public string station { get; set; }

        public int? controlTypeId { get; set; }

        [StringLength(50)]
        public string route { get; set; }

        public int? counter { get; set; }

        [StringLength(50)]
        public string zone { get; set; }

        [StringLength(50)]
        public string wagon { get; set; }

        [StringLength(4000)]
        public string confirmedLineReason { get; set; }

        public virtual tblTaskType tblTaskType { get; set; }
    }
}
