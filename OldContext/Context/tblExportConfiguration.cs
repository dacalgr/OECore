namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblExportConfiguration")]
    public partial class tblExportConfiguration
    {
        public tblExportConfiguration()
        {
            tblDomainExportTime = new HashSet<tblDomainExportTime>();

        }

        public int id { get; set; }

        [StringLength(64)]
        public string domain { get; set; }

        [StringLength(32)]
        public string task { get; set; }

        [StringLength(32)]
        public string task_test { get; set; }

        [StringLength(32)]
        public string incident { get; set; }

        [StringLength(32)]
        public string incident_test { get; set; }

        [StringLength(32)]
        public string picture { get; set; }

        [StringLength(32)]
        public string picture_test { get; set; }

        [StringLength(32)]
        public string quittung { get; set; }

        [StringLength(32)]
        public string quittung_test { get; set; }

        [StringLength(32)]
        public string ticketsales { get; set; }

        [StringLength(32)]
        public string ticketsales_test { get; set; }

        public DateTime? dtDeleted { get; set; }

        [StringLength(32)]
        public string forms { get; set; }

        [StringLength(32)]
        public string forms_test { get; set; }

        [StringLength(32)]
        public string users { get; set; }

        [StringLength(32)]
        public string users_test { get; set; }


        public bool IncidentAPIEnabled { get; set; } = false;
        public bool TaskAPIEnabled { get; set; } = false;
        public bool TicketAPIEnabled { get; set; } = false;



        [Column(TypeName = "datetime2")]
        public DateTime? incidentsLastExport { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? incidentsNextExport { get; set; }

        public int incidentsMinClosedTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime incidentsStartExport { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime incidentsEndExport { get; set; }
        //public bool exportInProcess { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDomainExportTime> tblDomainExportTime { get; set; }
    }
}
