namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tbl_TIMETABLE_calendar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string service_id { get; set; }
        public string monday { get; set; }
        public string tuesday { get; set; }
        public string wednesday { get; set; }
        public string thursday { get; set; }
        public string friday { get; set; }
        public string saturday { get; set; }
        public string sunday { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
    }
}