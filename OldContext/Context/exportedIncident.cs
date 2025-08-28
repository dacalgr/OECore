namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exportedIncident
    {
        public Guid id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exportedToSAP { get; set; }
    }
}
