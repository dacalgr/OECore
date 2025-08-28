namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tbl_TIMETABLE_trips
    {
        [Key]                                                 // Defines PK
        [DatabaseGenerated(DatabaseGeneratedOption.None)]      // No identity
        public string trip_id { get; set; }
        public string route_id { get; set; }
        public string service_id { get; set; }
        
        public string trip_headsign { get; set; }
        public string trip_short_name { get; set; }
        public string direction_id { get; set; }
        public string block_id { get; set; }
        public string shape_id { get; set; }
        public string wheelchair_accessible { get; set; }
        public string bikes_allowed { get; set; }

        [ForeignKey("route_id")]
        public virtual tbl_TIMETABLE_routes Route { get; set; }

        [ForeignKey("service_id")]
        public virtual tbl_TIMETABLE_calendar Service { get; set; }

        public virtual ICollection<tbl_TIMETABLE_stop_times> StopTimes { get; set; } // Navigation property for related stopTimes
    }
}