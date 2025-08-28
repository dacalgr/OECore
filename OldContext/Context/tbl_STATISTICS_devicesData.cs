namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_STATISTICS_devicesData
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string deviceId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string imei { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string mac { get; set; }
    }
}
