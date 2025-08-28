namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Routes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_Routes()
        {
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
            tbl_CONFIG_Stations = new HashSet<tbl_CONFIG_Stations>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(64)]
        public string destination { get; set; }

        public int? fColor { get; set; }

        public int? bColor { get; set; }

        public int? agencyid { get; set; }

        public int? vehicle { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }

        [StringLength(100)]
        public string bemerkung { get; set; }

        [StringLength(200)]
        public string update { get; set; }

        [StringLength(50)]
        public string glueName { get; set; }

        [StringLength(50)]
        public string glueDestination { get; set; }

        public DateTime? dtSharepointIimport { get; set; }

        [StringLength(100)]
        public string agencyName { get; set; }

        public virtual tbl_CONFIG_Agency tbl_CONFIG_Agency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Stations> tbl_CONFIG_Stations { get; set; }
    }
}
