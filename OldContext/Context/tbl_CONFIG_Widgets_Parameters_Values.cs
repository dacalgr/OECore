namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Widgets_Parameters_Values
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int widgetId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int parameterId { get; set; }

        public string value { get; set; }

        public virtual tbl_CONFIG_Parameters tbl_CONFIG_Parameters { get; set; }

        public virtual tbl_CONFIG_Widgets tbl_CONFIG_Widgets { get; set; }
    }
}
