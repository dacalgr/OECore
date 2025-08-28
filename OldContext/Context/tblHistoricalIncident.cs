namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblHistoricalIncident
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHistoricalIncident()
        {
            tblBillLines = new HashSet<tblBillLine>();
        }

        public Guid id { get; set; }

        public int? userId { get; set; }

        public int? cardTypeId { get; set; }

        public int? categoryCardTypeId { get; set; }

        [StringLength(4000)]
        public string name { get; set; }

        [StringLength(4000)]
        public string firstname { get; set; }

        [StringLength(4000)]
        public string address { get; set; }

        [StringLength(4000)]
        public string zip { get; set; }

        [StringLength(500)]
        public string email { get; set; }

        public DateTime? birthdate { get; set; }

        [StringLength(4000)]
        public string citzenship { get; set; }

        public int? titleId { get; set; }

        [StringLength(4000)]
        public string city { get; set; }

        [StringLength(4000)]
        public string country { get; set; }

        [StringLength(40)]
        public string countryCode { get; set; }

        [StringLength(4000)]
        public string extra { get; set; }

        [StringLength(4000)]
        public string tutorName { get; set; }

        [StringLength(4000)]
        public string tutorFirstname { get; set; }

        [StringLength(4000)]
        public string tutorAddress { get; set; }

        [StringLength(4000)]
        public string tutorZip { get; set; }

        [StringLength(500)]
        public string tutorEmail { get; set; }

        public DateTime? tutorBirthdate { get; set; }

        [StringLength(4000)]
        public string tutorCitizenship { get; set; }

        public int? tutorTitleId { get; set; }

        [StringLength(4000)]
        public string tutorCity { get; set; }

        [StringLength(4000)]
        public string tutorCountry { get; set; }

        [StringLength(40)]
        public string tutorCountryCode { get; set; }

        [StringLength(4000)]
        public string tutorExtra { get; set; }

        public bool? sendSMS { get; set; }

        public bool? sendEmail { get; set; }

        public int? billLines { get; set; }

        [StringLength(50)]
        public string zemisNr { get; set; }

        public DateTime? startTime { get; set; }

        public int? residencePermitId { get; set; }

        public decimal? remaining { get; set; }

        public int? firmId { get; set; }

        public decimal? deduction { get; set; }

        [StringLength(50)]
        public string behaviorCode { get; set; }

        [StringLength(4000)]
        public string place { get; set; }

        [StringLength(1000)]
        public string route { get; set; }

        [Column(TypeName = "text")]
        public string image { get; set; }

        [StringLength(4000)]
        public string number { get; set; }

        public bool? isOpen { get; set; }

        public DateTime? modified { get; set; }

        [StringLength(1000)]
        public string station { get; set; }

        [Column(TypeName = "text")]
        public string thumbnail { get; set; }

        public decimal? cash { get; set; }

        public int? step { get; set; }

        [StringLength(4000)]
        public string comments { get; set; }

        public decimal? total { get; set; }

        public Guid? incidentId { get; set; }

        [StringLength(4000)]
        public string fieldChanged { get; set; }

        [StringLength(50)]
        public string currency { get; set; }

        public bool? isAnon { get; set; }

        [StringLength(40)]
        public string hausnummer { get; set; }

        [StringLength(40)]
        public string tutorHausnummer { get; set; }

        [StringLength(50)]
        public string coAddress { get; set; }

        [StringLength(50)]
        public string tutorCoAddress { get; set; }

        public DateTime? uploadedDate { get; set; }

        public Guid? parentID { get; set; }

        [StringLength(50)]
        public string telephone { get; set; }

        public DateTime? deleted { get; set; }

        public bool? cancelled { get; set; }

        [StringLength(4000)]
        public string cancelledReason { get; set; }

        public decimal? factor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBillLine> tblBillLines { get; set; }
    }
}
