namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tbl_TIMETABLE_calendar_dates
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string service_id { get; set; }
        public string date { get; set; }
        public string exception_type { get; set; }

         [ForeignKey("service_id")]
        public virtual tbl_TIMETABLE_calendar Service { get; set; }

    }
}