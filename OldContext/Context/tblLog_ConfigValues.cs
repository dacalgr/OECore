namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblLog_ConfigValues
    {
        public int id { get; set; }

        [StringLength(50)]
        public string key { get; set; }

        [StringLength(50)]
        public string value { get; set; }
    }
}
