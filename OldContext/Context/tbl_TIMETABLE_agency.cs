namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tbl_TIMETABLE_agency
    {
        [Key]                                                 // Defines PK
        [DatabaseGenerated(DatabaseGeneratedOption.None)]      // No identity
        public string agency_id { get; set; }
        public string agency_name { get; set; }
        public string agency_url { get; set; }
        public string agency_timezone { get; set; }
        public string agency_lang { get; set; }
        public string agency_phone { get; set; }
        public string agency_fare_url { get; set; }
        public string agency_email { get; set; }

        public virtual ICollection<tbl_TIMETABLE_routes> Routes { get; set; }
    }
}