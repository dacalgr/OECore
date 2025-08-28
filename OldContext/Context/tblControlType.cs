namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblControlType
    {
        public int id { get; set; }

        [StringLength(4000)]
        public string nameDE { get; set; }

        [StringLength(4000)]
        public string nameFR { get; set; }

        [StringLength(4000)]
        public string nameIT { get; set; }

        public DateTime? dtCreated { get; set; }

        public DateTime? dtModified { get; set; }

        public DateTime? dtDeleted { get; set; }
    }
}
