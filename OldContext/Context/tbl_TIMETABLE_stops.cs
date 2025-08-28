namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tbl_TIMETABLE_stops
    {
        [Key]                                                 // Defines PK
        [DatabaseGenerated(DatabaseGeneratedOption.None)]      // No identity
        public string stop_id { get; set; }
        public string stop_code { get; set; }
        public string stop_name { get; set; }
        public string stop_desc { get; set; }
        public string stop_lat { get; set; }
        public string stop_lon { get; set; }
        public string zone_id { get; set; }
        public string stop_url { get; set; }
        public string location_type { get; set; }
        public string parent_station { get; set; }
        public string stop_timezone { get; set; }
        public string wheelchair_boarding { get; set; }
        public string level_id { get; set; }
        public string platform_code { get; set; }

        public virtual ICollection<tbl_TIMETABLE_stop_times> StopTimes { get; set; } // Navigation property for related trips
    }
}