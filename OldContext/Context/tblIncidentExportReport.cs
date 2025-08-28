namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblIncidentExportReport")]
    public partial class tblIncidentExportReport
    {
        [Key]
        public Guid incidentId { get; set; }

        [StringLength(150)]
        public string quittungsnummer { get; set; }

        public int? laufnummer { get; set; }

        public int? userID { get; set; }

        [StringLength(500)]
        public string personalNummer { get; set; }

        public int? partnerTuID { get; set; }

        [StringLength(80)]
        public string partnerTu { get; set; }

        public int? kontrollart { get; set; }

        [StringLength(160)]
        public string linie { get; set; }

        [StringLength(100)]
        public string linieNr { get; set; }

        [StringLength(256)]
        public string richtung { get; set; }

        [StringLength(256)]
        public string kontrollhaltestelle { get; set; }

        [StringLength(80)]
        public string stranfantragscode { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? kontrolldatum { get; set; }

        [StringLength(10)]
        public string geschlechtFahrgast { get; set; }

        [StringLength(500)]
        public string nachnameFahrgast { get; set; }

        [StringLength(500)]
        public string vornameFahrgast { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? geburtsdatumFahrgast { get; set; }

        [StringLength(500)]
        public string wohnortFahrgast { get; set; }

        [StringLength(500)]
        public string strasseFahrgast { get; set; }

        [StringLength(500)]
        public string hausnummerFahrgast { get; set; }

        [StringLength(20)]
        public string wohnlandFahrgast { get; set; }

        [StringLength(500)]
        public string postleitzahlFahrgast { get; set; }

        [StringLength(500)]
        public string adresseFahrgast { get; set; }

        [StringLength(500)]
        public string zusatzadresseFahrgast { get; set; }

        [StringLength(500)]
        public string bürgerortFahrgast { get; set; }

        [StringLength(64)]
        public string mailAdresse { get; set; }

        [StringLength(160)]
        public string mobileNummer { get; set; }

        [StringLength(10)]
        public string geschlechtErzieher { get; set; }

        [StringLength(500)]
        public string nachnameErzieher { get; set; }

        [StringLength(500)]
        public string vornameErzieher { get; set; }

        [StringLength(500)]
        public string adresseErzieher { get; set; }

        [StringLength(500)]
        public string wohnortErzieher { get; set; }

        [StringLength(500)]
        public string wohnlandErzieher { get; set; }

        [StringLength(500)]
        public string strasseErzieher { get; set; }

        [StringLength(500)]
        public string hausnummerErzieher { get; set; }

        [StringLength(40)]
        public string postleitzahlErzieher { get; set; }

        [StringLength(500)]
        public string zusatzadresseErzieher { get; set; }

        [StringLength(500)]
        public string tutorEmail { get; set; }

        [StringLength(50)]
        public string tutorPhone { get; set; }

        [StringLength(30)]
        public string ausweisart { get; set; }

        [StringLength(500)]
        public string ausweisnummer { get; set; }

        [StringLength(500)]
        public string zemisnummer { get; set; }

        [StringLength(500)]
        public string ausstellungsortDesAusweises { get; set; }

        [StringLength(500)]
        public string beanstandungsgrund1 { get; set; }

        [StringLength(500)]
        public string beanstandungsgrund2 { get; set; }

        [StringLength(500)]
        public string beanstandungsgrund3 { get; set; }

        [StringLength(500)]
        public string beanstandungsgrund4 { get; set; }

        [StringLength(30)]
        public string währung { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? wechselkurs { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? barzahlungInCHF { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? barzahlungInFremdwahrung { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? kreditkartenzahlung { get; set; }
        
        [Column(TypeName = "numeric")]
        public decimal? onlinekartenzahlung { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? grundgebühr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? fahrpreispauschale { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? bearbeitungssgebuhr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? missbrauchsgebuhr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? falschungsgebühr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? zeitzuschlagsgebuhr { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? diverseGebuhren { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ruckgeldInCHF { get; set; }

        [StringLength(20)]
        public string verhaltenKunde1 { get; set; }

        [StringLength(4000)]
        public string bemerkungKontrolleur { get; set; }

        public bool? storno { get; set; }

        [StringLength(500)]
        public string begrundungStorno { get; set; }

        [StringLength(500)]
        public string zone { get; set; }

        [StringLength(500)]
        public string wagennummer { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exportTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? exportedToCsv { get; set; }

        [StringLength(500)]
        public string domain { get; set; }

        [StringLength(20)]
        public string companyCode { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? total { get; set; }

        [StringLength(500)]
        public string name { get; set; }

        [StringLength(500)]
        public string lastName { get; set; }

        public int? employerId { get; set; }

        [StringLength(100)]
        public string employerName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? controlTimeStamp { get; set; }

        [StringLength(50)]
        public string persID { get; set; }

        [StringLength(50)]
        public string hbkKey { get; set; }

        [StringLength(50)]
        public string tutorPersID { get; set; }

        [StringLength(50)]
        public string tutorHbkKey { get; set; }

        [StringLength(1000)]
        public string begrundung1erFall { get; set; }

        ////////////////////////////////////////////////////PP-6387 Digitallisierung
        [StringLength(500)]
        public string AbuseOption { get; set; }
        [StringLength(500)]
        public string ConfirmationOfPersonalDetailsOption { get; set; }
        [StringLength(500)]
        public string ContactPersonOption { get; set; }
        [StringLength(500)]
        public string ForgeryComment { get; set; }
        public int? TimeClarification { get; set; }
        [StringLength(500)]
        public string PersonalDetailsComment { get; set; }
        /////////////////////////////////////////////////PassengerPreferredLanguage
        [StringLength(10)]
        public string PassengerPreferredLanguage { get; set; }

        //////////////////////////////////////////////Payment Confirmation flags
        public bool ConfirmedNOBackendAccess { get; set; }
        public bool ConfirmedNOPaymentProviderAccess { get; set; }
        public bool ConfirmedWithNOPayment { get; set; }
        public int PayrexxGatewayId { get; set; }

        public bool RefundAttempt { get; set; }
        public int QRGenerations { get; set; }
        public int QRDownloads { get; set; }
        public int PrintingAttempts { get; set; }
        public int MailSendings { get; set; }

    }
}
