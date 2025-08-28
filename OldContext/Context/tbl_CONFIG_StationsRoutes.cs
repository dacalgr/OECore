namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_StationsRoutes
    {
        public int id { get; set; }

        public int stationId { get; set; }

        public int routeId { get; set; }

        [StringLength(50)]
        public string station { get; set; }

        [StringLength(8)]
        public string route { get; set; }
    }
}
