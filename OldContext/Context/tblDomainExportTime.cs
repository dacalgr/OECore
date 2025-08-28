namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;


    public partial class tblDomainExportTime
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        

        public int id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime exportTime { get; set; }

        public int? tblExportConfiguration_id { get; set; }

        [ForeignKey("tblExportConfiguration_id")]
        [InverseProperty("tblDomainExportTime")]
        public tblExportConfiguration tblExportConfiguration { get; set; }

    }
}
