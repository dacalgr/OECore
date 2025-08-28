namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_TableMapping
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string sqlServerName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string sqliteName { get; set; }

        public int order { get; set; }
    }
}
