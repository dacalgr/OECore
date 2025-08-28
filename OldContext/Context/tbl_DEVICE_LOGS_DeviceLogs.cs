namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DEVICE_LOGS_DeviceLogs
    {
        public int id { get; set; }

        [StringLength(128)]
        public string zipName { get; set; }

        public DateTime? tStamp { get; set; }

        [Column(TypeName = "text")]
        public string tag { get; set; }

        [Column(TypeName = "text")]
        public string timestamp { get; set; }

        [Column(TypeName = "text")]
        public string response { get; set; }

        [Column(TypeName = "text")]
        public string deviceid { get; set; }

        [Column(TypeName = "text")]
        public string imei { get; set; }

        [Column(TypeName = "text")]
        public string file { get; set; }

        [Column(TypeName = "text")]
        public string versionnumber { get; set; }

        [Column(TypeName = "text")]
        public string version { get; set; }

        [Column(TypeName = "text")]
        public string datetime { get; set; }

        [Column(TypeName = "text")]
        public string userid { get; set; }

        [Column(TypeName = "text")]
        public string mode { get; set; }

        [Column(TypeName = "text")]
        public string request { get; set; }

        [Column(TypeName = "text")]
        public string incidentid { get; set; }

        [Column(TypeName = "text")]
        public string starttime { get; set; }

        [Column(TypeName = "text")]
        public string log { get; set; }

        [Column(TypeName = "text")]
        public string error { get; set; }

        [Column(TypeName = "text")]
        public string taskid { get; set; }

        [Column(TypeName = "text")]
        public string data { get; set; }

        [Column(TypeName = "text")]
        public string turnid { get; set; }

        [Column(TypeName = "text")]
        public string stoptime { get; set; }

        [Column(TypeName = "text")]
        public string json { get; set; }

        [Column(TypeName = "text")]
        public string tasktype { get; set; }

        [Column(TypeName = "text")]
        public string exception { get; set; }

        [StringLength(32)]
        public string hash { get; set; }

        [Column(TypeName = "text")]
        public string updateblacklist { get; set; }

        [Column(TypeName = "text")]
        public string image { get; set; }

        [Column(TypeName = "text")]
        public string message { get; set; }
    }
}
