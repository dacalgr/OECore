namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Dashboards_Widgets
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int dashboardId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int widgetId { get; set; }

        public int? order { get; set; }

        public int? startX { get; set; }

        public int? startY { get; set; }

        public int? endX { get; set; }

        public int? endY { get; set; }

        public virtual tbl_CONFIG_Dashboards tbl_CONFIG_Dashboards { get; set; }

        public virtual tbl_CONFIG_Widgets tbl_CONFIG_Widgets { get; set; }
    }
}
