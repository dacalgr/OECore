namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DEVICE_LOGS_IncidentLogs
    {
        public int id { get; set; }

        public DateTime? tStamp { get; set; }

        [Column(TypeName = "text")]
        public string timestamp { get; set; }

        public string dbversion { get; set; }

        public string message { get; set; }

        public string incidentid { get; set; }

        public string deviceid { get; set; }

        public string imei { get; set; }

        public string userid { get; set; }

        public string dblastupdate { get; set; }

        public string version { get; set; }

        public string datetime { get; set; }

        public string mode { get; set; }

        public string total { get; set; }

        public string firmname { get; set; }

        public string tutorbirthland { get; set; }

        public string tutorcity { get; set; }

        public string tutortitleid { get; set; }

        public string cardtypeid { get; set; }

        public string tutorname { get; set; }

        public string wagennummer { get; set; }

        public string tutorbirthdate { get; set; }

        public string hausnummer { get; set; }

        public string taskid { get; set; }

        public string city { get; set; }

        public string starttime { get; set; }

        public string turnid { get; set; }

        public string receiptprinted { get; set; }

        public string firmid { get; set; }

        public string place { get; set; }

        public string tutorhausnummer { get; set; }

        public string coaddress { get; set; }

        public string regionid { get; set; }

        public string exportedtosap { get; set; }

        public string station { get; set; }

        public string extra { get; set; }

        public string cancelled { get; set; }

        public string regionname { get; set; }

        public string countrycode { get; set; }

        public string cancelledreason { get; set; }

        public string number { get; set; }

        public string tutorzip { get; set; }

        public string confirmedline { get; set; }

        public string modified { get; set; }

        public string country { get; set; }

        public string email { get; set; }

        public string cash { get; set; }

        public string images { get; set; }

        public string sendemail { get; set; }

        public string birthland { get; set; }

        public string titleid { get; set; }

        public string uploadeddate { get; set; }

        public string paymentmode { get; set; }

        public string sendsms { get; set; }

        public string closeddate { get; set; }

        public string timezone { get; set; }

        public string citizenship { get; set; }

        public string deltavistaresult { get; set; }

        public string tutorextra { get; set; }

        public string billlines { get; set; }

        public string currency { get; set; }

        public string zemisnr { get; set; }

        public string parentid { get; set; }

        public string residencepermitid { get; set; }

        public string categorycardtypeid { get; set; }

        public string remaining { get; set; }

        public string tutorfirstname { get; set; }

        public string tutorcoaddress { get; set; }

        public string name { get; set; }

        public string birthdate { get; set; }

        public string deltavistaresponse { get; set; }

        public string deduction { get; set; }

        public string tutoraddress { get; set; }

        public string zip { get; set; }

        public string tutorcountry { get; set; }

        public string firstname { get; set; }

        public string isopen { get; set; }

        public string isanon { get; set; }

        public string balanced { get; set; }

        public string address { get; set; }

        public string route { get; set; }

        public string confirmedlinecomments { get; set; }

        public string behaviorcode { get; set; }

        public string lastmodificationdate { get; set; }

        public string telephone { get; set; }

        public string tutorcountrycode { get; set; }

        public string step { get; set; }

        public string comments { get; set; }

        public string zone { get; set; }

        public string factor { get; set; }

        public string anonymousreason { get; set; }

        public string change { get; set; }

        public string startlatitude { get; set; }

        public string startlongitude { get; set; }

        public string versionnumber { get; set; }

        public string file { get; set; }

        public string response { get; set; }
    }
}
