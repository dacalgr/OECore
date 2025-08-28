namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblBillLine
    {
        public int id { get; set; }

        public int? billId { get; set; }

        public decimal? surcharge { get; set; }

        public decimal? fare { get; set; }

        public decimal? fee { get; set; }

        public decimal? abuse { get; set; }

        public decimal? forgery { get; set; }

        public decimal? time_penalties { get; set; }

        public decimal? miscellaneus { get; set; }

        public decimal? total { get; set; }

        public Guid? incidentId { get; set; }

        public Guid? historicalIncidentId { get; set; }

        [StringLength(4000)]
        public string comments { get; set; }

        public DateTime? lastModificationDate { get; set; }

        public virtual tblHistoricalIncident tblHistoricalIncident { get; set; }

        public virtual tblIncident tblIncident { get; set; }
    }
}
