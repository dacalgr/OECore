namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Stations
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_Stations()
        {
            tbl_CONFIG_Routes = new HashSet<tbl_CONFIG_Routes>();
        }

        public int id { get; set; }

        public float didok { get; set; }

        public int? didoklong { get; set; }

        [StringLength(512)]
        public string name { get; set; }

        [StringLength(512)]
        public string ort { get; set; }

        [StringLength(50)]
        public string systemName { get; set; }

        public float? lat { get; set; }

        public float? lng { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? straaid { get; set; }

        [StringLength(512)]
        public string zone { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }

        [StringLength(50)]
        public string kantonsKurzel { get; set; }

        [StringLength(100)]
        public string bemerkung { get; set; }

        [StringLength(200)]
        public string update { get; set; }

        public DateTime? dtSharepointIimport { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Routes> tbl_CONFIG_Routes { get; set; }
    }
}
