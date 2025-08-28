namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Dashboards_Applications
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dashboardId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int applicationId { get; set; }

        public int? order { get; set; }

        public bool? inDock { get; set; }

        public virtual tbl_CONFIG_Applications tbl_CONFIG_Applications { get; set; }

        public virtual tbl_CONFIG_Dashboards tbl_CONFIG_Dashboards { get; set; }
    }
}
