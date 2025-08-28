namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_BACKUP_Companies_Regions
    {
        public int id { get; set; }

        public int company { get; set; }

        public int region { get; set; }

        public DateTime? dtPublished { get; set; }
    }
}
