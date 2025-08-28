namespace OpenEyeBackendEntities
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tbl_TIMETABLE_stop_times
    {
        public int id { get; set; }
        public string trip_id { get; set; }
        public string arrival_time { get; set; }
        public string departure_time { get; set; }
        public string stop_id { get; set; }
        public string stop_sequence { get; set; }
        public string stop_headsign { get; set; }
        public string pickup_type { get; set; }
        public string drop_off_type { get; set; }
        public string shape_dist_traveled { get; set; }
        public string timepoint { get; set; }

        [ForeignKey("stop_id")]
        public virtual tbl_TIMETABLE_stops Stop { get; set; }

        [ForeignKey("trip_id")]
        public virtual tbl_TIMETABLE_trips Trip { get; set; }
    }
}