namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblTaskExportReport")]
    public partial class tblTaskExportReport
    {
        [Key]
        public Guid taskID { get; set; }

        [StringLength(50)]
        public string personalNumber { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dateTimeFrom { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dateTimeTo { get; set; }

        [StringLength(50)]
        public string line { get; set; }

        [StringLength(50)]
        public string direction { get; set; }

        [StringLength(50)]
        public string station { get; set; }

        public int? kontrollArtID { get; set; }

        [StringLength(50)]
        public string kontrollArt { get; set; }

        [StringLength(50)]
        public string bezirk { get; set; }

        [StringLength(100)]
        public string tastkType { get; set; }

        [StringLength(100)]
        public string freeText { get; set; }

        [StringLength(50)]
        public string journal { get; set; }

        public int? controlsAmount { get; set; }

        public int? incidentsAmount { get; set; }

        [StringLength(50)]
        public string employer { get; set; }

        [StringLength(50)]
        public string anmeldeID { get; set; }

        [StringLength(50)]
        public string department { get; set; }

        [StringLength(50)]
        public string vehicleType { get; set; }

        [StringLength(50)]
        public string amount { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        public int? flightCount { get; set; }

        public int? aggression { get; set; }

        [StringLength(50)]
        public string wagennummer { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exportTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exportedToCsv { get; set; }

        [StringLength(100)]
        public string tastkType_ { get; set; }

        public Guid? turnId { get; set; }

        public int? userId { get; set; }

        public DateTime? turnStartTime { get; set; }

        public DateTime? turnStopTime { get; set; }

        public int? ticketsAmount { get; set; }

        [StringLength(50)]
        public string employerUser { get; set; }

        public bool? fullControl { get; set; }
    }
}
