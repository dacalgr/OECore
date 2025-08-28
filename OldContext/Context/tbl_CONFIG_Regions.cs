namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Regions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_Regions()
        {
            tbl_FORMS_Surveys = new HashSet<tbl_FORMS_Surveys>();
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string shortName { get; set; }

        [StringLength(500)]
        public string name { get; set; }

        public int? inmodo_TCID { get; set; }

        public int? voevCode { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }

        [StringLength(512)]
        public string printContinue { get; set; }

        [StringLength(512)]
        public string printContinueFR { get; set; }

        [StringLength(512)]
        public string printContinueIT { get; set; }

        [StringLength(512)]
        public string printContinueEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FORMS_Surveys> tbl_FORMS_Surveys { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }
    }
}
