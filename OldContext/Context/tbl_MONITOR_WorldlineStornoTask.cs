namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("tbl_MONITOR_WorldlineStornoTask")]
    public partial class tbl_MONITOR_WorldlineStornoTask
    {
        [Key]
        public int id { get; set; }

        [ForeignKey("incident")]
        public Guid incidentId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtCompleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCreated { get; set; }

        public virtual tblIncidentExportReport incident { get; set; }
    }
}
