namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Log
    {
        public int id { get; set; }

        [StringLength(150)]
        public string userEmail { get; set; }

        [StringLength(50)]
        public string userUsername { get; set; }

        [StringLength(50)]
        public string userDisplayName { get; set; }

        [StringLength(100)]
        public string entityName { get; set; }

        [StringLength(100)]
        public string entityId { get; set; }

        public DateTime? timestamp { get; set; }

        [StringLength(20)]
        public string operation { get; set; }

        public string oldValues { get; set; }

        public string newValues { get; set; }
    }
}
