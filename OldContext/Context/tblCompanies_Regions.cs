namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCompanies_Regions
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int company { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int region { get; set; }

        public DateTime? dtLastSQLIteImport { get; set; }

        public virtual tblCompany tblCompany { get; set; }

        public virtual tblRegion tblRegion { get; set; }
    }
}
