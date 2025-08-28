namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DEBUG_Queries
    {
        [Key]
        [StringLength(64)]
        public string name { get; set; }

        [Column(TypeName = "text")]
        public string query { get; set; }
    }
}
