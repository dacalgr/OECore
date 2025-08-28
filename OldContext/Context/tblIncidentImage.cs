namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblIncidentImage
    {
        public int id { get; set; }

        [StringLength(500)]
        public string imageName { get; set; }

        [Column(TypeName = "text")]
        public string imageContent { get; set; }

        public Guid? incident { get; set; }

        public bool isQuittung { get; set; }

        public virtual tblIncident tblIncident { get; set; }
    }
}
