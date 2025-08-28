namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblIncident
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblIncident()
        {
            tblBillLines = new HashSet<tblBillLine>();
            tblIncidentImages = new HashSet<tblIncidentImage>();
        }

        public Guid id { get; set; }
        public Guid? turnID { get; set; }

        public Guid? taskID { get; set; }

        public int? userId { get; set; }

        public int? cardTypeId { get; set; }

        public int? categoryCardTypeId { get; set; }
        [StringLength(50)]
        public string quitNo { get; set; }
        public int? firmId { get; set; }
        [Column(TypeName = "text")]
        public string image { get; set; }
        [StringLength(4000)]
        public string comments { get; set; }
        [Column(TypeName = "text")]
        public string thumbnail { get; set; }
        public int? step { get; set; }
        public Guid? parentID { get; set; }
        public bool? cancelled { get; set; }
        [StringLength(4000)]
        public string cancelledReason { get; set; }
        public int? cancelledReasonID { get; set; }
        public int? autoIncrement { get; set; }
        public bool ConfirmedWarningMailSent { get; set; }

        #region passenger
        [StringLength(50)]
        public string behaviorCode { get; set; }
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

        [Column(TypeName = "datetime2")]
        public DateTime? birthdate { get; set; }

        [StringLength(50)]
        public string birthLand { get; set; }

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
        [StringLength(50)]
        public string zemisNr { get; set; }
        public int? residencePermitId { get; set; }
        public bool? isAnon { get; set; }

        [StringLength(40)]
        public string hausnummer { get; set; }
        [StringLength(50)]
        public string coAddress { get; set; }
        [StringLength(50)]
        public string telephone { get; set; }
        [StringLength(1000)]
        public string anonymousReason { get; set; }
        [StringLength(50)]
        public string persID { get; set; }

        [StringLength(50)]
        public string hbkKey { get; set; }
        public bool scanned { get; set; }
        public bool AMPDataModified { get; set; }
        [StringLength(25)]
        public string passengerPreferredLanguage { get; set; }
        
        
        #endregion


        #region tutor
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

        [StringLength(50)]
        public string tutorPhone { get; set; }

        [Column(TypeName = "datetime2")]
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
        [StringLength(40)]
        public string tutorHausnummer { get; set; }
        [StringLength(50)]
        public string tutorCoAddress { get; set; }
        [StringLength(50)]
        public string tutorPersID { get; set; }

        [StringLength(50)]
        public string tutorHbkKey { get; set; }
        #endregion


        #region incident_deployment
        public bool? sendSMS { get; set; }

        public bool? mailRequestFlag { get; set; }
        public int MailNumber { get; set; }
        public bool? receiptPrinted { get; set; }
        public int PrintNumber { get; set; }



        public bool RefundAttempt { get; set; }
        public int QRGenerations { get; set; }

        public int QRDownloads { get; set; }

        public string DownloadToken { get; set; }



        [Column(TypeName = "datetime2")]
        public DateTime? alreadySentSMS { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? sentMailOK { get; set; }
        public int? mailRetryNumber { get; set; }
        [StringLength(5000)]
        public string SMTPLastResponse { get; set; }
        #endregion


        #region dates
        [Column(TypeName = "datetime2")]
        public DateTime? startTime { get; set; }
        [StringLength(100)]
        public string timezone { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? modified { get; set; }
        public DateTime? DtNotified { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exportedToSAP { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? uploadedDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? deleted { get; set; }
        public long? startTimeReceived { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? closedDate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? lastModificationDate { get; set; }
        public DateTime? balanced { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? controlTimeStamp { get; set; }

        public DateTime? cashChecked { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtProcessed { get; set; }
        #endregion


        #region paymentData
        public decimal? remaining { get; set; }
        public decimal? deduction { get; set; }
        public decimal? cash { get; set; }
        public decimal? total { get; set; }
        [StringLength(50)]
        public string currency { get; set; }
        public int? paymentMode { get; set; }

        public decimal? factor { get; set; }

        public decimal? change { get; set; }
        public bool IsOnlinePaid { get; set; }
        [StringLength(1000)]
        public string onlineTransactionID { get; set; }
        //Payrexx confirm payment flags
        public bool ConfirmedWithNOPayment { get; set; }
        public bool ConfirmedNOBackendAccess { get; set; }
        public bool ConfirmedNOPaymentProviderAccess { get; set; }
        public int PayrexxGatewayId { get; set; }

        public string PaymentMethod { get; set; }
        #endregion


        #region IncidentLocation

        [StringLength(4000)]
        public string place { get; set; }

        [StringLength(1000)]
        public string route { get; set; }
        [StringLength(4000)]
        public string number { get; set; }
        [StringLength(1000)]
        public string station { get; set; }
        #endregion


        #region incidentStatus
        public bool? isOpen { get; set; }
        [StringLength(50)]
        public string zone { get; set; }
        [StringLength(200)]
        public string wagennummer { get; set; }
        public bool? confirmedLine { get; set; }
        [StringLength(4000)]
        public string confirmedLineComments { get; set; }
        public int? region { get; set; }

        [StringLength(100)]
        public string regionName { get; set; }
        [Column(TypeName = "numeric")]
        public decimal? latitude { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? longitude { get; set; }

        [StringLength(100)]
        public string routeNumber { get; set; }
        #endregion

        #region Abuse
        //Digitallisierung BemerkungsZettel
        public int? AbuseOption { get; set; }
        public int? ConfirmationOfPersonalDetailsOption { get; set; }
        public int? ContactPersonOption { get; set; }

        public string forgeryComment { get; set; }
        public int? timeClarification { get; set; }
        public string personalDetailsComment { get; set; }

        public bool? isAbuse { get; set; }
        #endregion
        //PP-6423
        


        

        public virtual tbl_CONFIG_Companies tbl_CONFIG_Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBillLine> tblBillLines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblIncidentImage> tblIncidentImages { get; set; }
    }
}
