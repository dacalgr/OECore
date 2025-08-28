namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTask()
        {
            tblTaskTypes = new HashSet<tblTaskType>();
        }

        public Guid id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? startTime { get; set; }

        public Guid? turnId { get; set; }

        public int? firmId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        [StringLength(20)]
        public string type { get; set; }

        public int? teamId { get; set; }

        [StringLength(4000)]
        public string station { get; set; }

        [StringLength(4000)]
        public string stationsList { get; set; }

        public int? controlTypeId { get; set; }

        [StringLength(50)]
        public string route { get; set; }

        public int? counter { get; set; }

        [StringLength(50)]
        public string zone { get; set; }

        [StringLength(50)]
        public string wagon { get; set; }

        public bool? confirmedline { get; set; }

        [StringLength(4000)]
        public string confirmedLineReason { get; set; }

        public long? subcategoryId { get; set; }

        public long? category { get; set; }

        public Guid? oldTurnID { get; set; }

        public int? region { get; set; }

        public string freeText { get; set; }

        [StringLength(300)]
        public string regionName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? balanced { get; set; }

        public int? firmId_ { get; set; }

        public Guid? turnId_ORIG { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? longitude { get; set; }

        public bool? fullControl { get; set; }

       public int? flightCount { get; set; }

        public int? aggression { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtProcessed { get; set; }
        public string deviceId { get; set; }


        public virtual tbl_CONFIG_Companies tbl_CONFIG_Companies { get; set; }

        public virtual tblTurn tblTurn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTaskType> tblTaskTypes { get; set; }
    }
}
