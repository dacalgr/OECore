namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_CleanJobs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_CleanJobs()
        {
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
        }

        public int id { get; set; }

        public int? freqIncidentImages { get; set; }

        public int? freqIncidents { get; set; }
        

        public int? freqTasks { get; set; }

        public int? freqTurns { get; set; }

        public int? freqTickets { get; set; }

        public int? freqSurveys { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }
    }
}
