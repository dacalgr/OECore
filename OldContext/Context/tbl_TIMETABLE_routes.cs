namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tbl_TIMETABLE_routes
    {
        [Key]                                                 // Defines PK
        [DatabaseGenerated(DatabaseGeneratedOption.None)]      // No identity
        public string route_id { get; set; }
        public string agency_id { get; set; }
        public string route_short_name { get; set; }
        public string route_long_name { get; set; }
        public string route_desc { get; set; }
        public string route_type { get; set; }
        public string route_url { get; set; }
        public string route_color { get; set; }
        public string route_text_color { get; set; }

        [ForeignKey(nameof(agency_id))]
        [Column("agency_id")]
        public virtual tbl_TIMETABLE_agency Agency { get; set; }
        public virtual ICollection<tbl_TIMETABLE_trips> Trips { get; set; } // Navigation property for related trips
    }
}