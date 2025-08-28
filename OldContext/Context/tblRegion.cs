namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblRegion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblRegion()
        {
            tblCompanies = new HashSet<tblCompany>();
            tblCompanies_Regions = new HashSet<tblCompanies_Regions>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string shortName { get; set; }

        [StringLength(500)]
        public string name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        public int? inmodo_TCID { get; set; }

        public int? voevCode { get; set; }

        public DateTime? dtLastSQLIteImport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompany> tblCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompanies_Regions> tblCompanies_Regions { get; set; }
    }
}
