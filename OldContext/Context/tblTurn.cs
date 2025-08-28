namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTurn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTurn()
        {
            tblTasks = new HashSet<tblTask>();
        }

        public Guid id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? startTime { get; set; }

        public int? userId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? stopTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exportTime { get; set; }

        [StringLength(4000)]
        public string notes { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? oldStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? oldStopTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? balanced { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? stopTime_ { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? turnStop_ORIG { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? turnStart_ORIG { get; set; }

        public bool? is_disabled { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? longitude { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTask> tblTasks { get; set; }
    }
}
