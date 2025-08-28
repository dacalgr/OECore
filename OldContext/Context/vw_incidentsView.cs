namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_incidentsView
    {
        [Key]
        public Guid incidentId { get; set; }

        public int? userId { get; set; }

        [StringLength(50)]
        public string quitNo { get; set; }

        [StringLength(50)]
        public string personalNumber { get; set; }

        public int? tuId { get; set; }

        [StringLength(50)]
        public string shortName { get; set; }

        [StringLength(1000)]
        public string route { get; set; }

        [StringLength(1000)]
        public string station { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? startTime { get; set; }

        public int? titleId { get; set; }

        [StringLength(4000)]
        public string name { get; set; }

        [StringLength(4000)]
        public string firstname { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? birthdate { get; set; }

        [StringLength(4000)]
        public string city { get; set; }

        [StringLength(4000)]
        public string address { get; set; }

        [StringLength(40)]
        public string hausnummer { get; set; }

        [StringLength(40)]
        public string countryCode { get; set; }

        [StringLength(4000)]
        public string zip { get; set; }

        [StringLength(50)]
        public string coAddress { get; set; }

        [StringLength(4000)]
        public string extra { get; set; }

        [StringLength(50)]
        public string birthLand { get; set; }

        [StringLength(500)]
        public string email { get; set; }

        [StringLength(50)]
        public string telephone { get; set; }

        public int? tutorTitleId { get; set; }

        [StringLength(4000)]
        public string tutorName { get; set; }

        [StringLength(4000)]
        public string tutorFirstname { get; set; }

        [StringLength(50)]
        public string tutorCoAddress { get; set; }

        [StringLength(4000)]
        public string tutorCity { get; set; }

        [StringLength(4000)]
        public string tutorAddress { get; set; }

        [StringLength(4000)]
        public string tutorZip { get; set; }

        [StringLength(4000)]
        public string tutorExtra { get; set; }

        public int? cardTypeId { get; set; }

        [StringLength(4000)]
        public string number { get; set; }

        [StringLength(50)]
        public string zemisNr { get; set; }

        [StringLength(4000)]
        public string place { get; set; }

        public int? paymentMode { get; set; }

        public decimal? cash { get; set; }

        [StringLength(50)]
        public string behaviorCode { get; set; }

        [StringLength(4000)]
        public string comments { get; set; }

        public bool? cancelled { get; set; }

        [Column(TypeName = "text")]
        public string refundReasonDe { get; set; }

        [Column(TypeName = "text")]
        public string refundReasonFr { get; set; }

        [StringLength(512)]
        public string refundReasonIt { get; set; }

        [StringLength(50)]
        public string zone { get; set; }

        [StringLength(200)]
        public string wagennummer { get; set; }

        [StringLength(4000)]
        public string citzenship { get; set; }

        [StringLength(50)]
        public string currency { get; set; }

        public int? categoryCardTypeId { get; set; }

        [StringLength(40)]
        public string tutorHausnummer { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? straaid { get; set; }

        [StringLength(8)]
        public string cardTypeCode { get; set; }

        [StringLength(8)]
        public string residenceCardTypeCode { get; set; }

        public int? refundReasonId { get; set; }

        [StringLength(10)]
        public string companyLanguage { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exportedToSAP { get; set; }

        public Guid? parentID { get; set; }

        public bool? isOpen { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? deleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? closedDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int laufnummer { get; set; }

        public bool? exported { get; set; }
    }
}
