namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Agency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_Agency()
        {
            tbl_CONFIG_Routes = new HashSet<tbl_CONFIG_Routes>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        [StringLength(100)]
        public string phone { get; set; }

        [StringLength(200)]
        public string url { get; set; }

        [StringLength(100)]
        public string bavK { get; set; }

        [StringLength(100)]
        public string bavL { get; set; }

        public int? fColor { get; set; }

        public int? bColor { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Routes> tbl_CONFIG_Routes { get; set; }
    }
}
