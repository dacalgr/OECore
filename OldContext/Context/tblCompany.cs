namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCompany()
        {
            tblCompanies_Regions = new HashSet<tblCompanies_Regions>();
           // tblCompaniesTeams = new HashSet<tblCompaniesTeam>();
            //tblTeams = new HashSet<tblTeam>();
            tblEmployers = new HashSet<tblEmployer>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string shortName { get; set; }

        [StringLength(512)]
        public string name { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        public int? region { get; set; }

        [StringLength(50)]
        public string domainIncident { get; set; }

        [StringLength(50)]
        public string domainPicture { get; set; }

        [StringLength(50)]
        public string domainTask { get; set; }

        [StringLength(50)]
        public string domainTicketsales { get; set; }

        [StringLength(512)]
        public string emailBody { get; set; }

        [StringLength(512)]
        public string emailSalutation { get; set; }

        [StringLength(512)]
        public string emailIntroduction { get; set; }

        [StringLength(512)]
        public string emailRepeat { get; set; }

        [StringLength(512)]
        public string emailContinue { get; set; }

        [StringLength(512)]
        public string emailPresentation { get; set; }

        [StringLength(512)]
        public string emailPortal { get; set; }

        [StringLength(512)]
        public string logoUrl { get; set; }

        [StringLength(10)]
        public string language { get; set; }

        [StringLength(50)]
        public string mwst { get; set; }
        public string mwst_FR { get; set; }
        [StringLength(50)]
        public string mwst_IT { get; set; }
        [StringLength(50)]
        public string mwst_EN { get; set; }

        [StringLength(50)]
        public string VoeVTUCode { get; set; }

        [StringLength(50)]
        public string VoeTarifVerbundCode { get; set; }

        public bool? AddQR { get; set; }

        [StringLength(512)]
        public string printLogo { get; set; }

        [StringLength(50)]
        public string shortNameX { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }

        [StringLength(512)]
        public string addressInReceipt { get; set; }

        [StringLength(512)]
        public string printRepeat { get; set; }

        [StringLength(512)]
        public string printContinue { get; set; }

        [StringLength(512)]
        public string printSalesPoint { get; set; }

        [StringLength(512)]
        public string printPortal { get; set; }

        [StringLength(512)]
        public string printSignature { get; set; }

        [StringLength(512)]
        public string emailLogo { get; set; }

        [StringLength(512)]
        public string emailSalutationFR { get; set; }

        [StringLength(512)]
        public string emailSalutationIT { get; set; }

        [StringLength(512)]
        public string emailSalutationEN { get; set; }

        [StringLength(512)]
        public string emailIntroductionFR { get; set; }

        [StringLength(512)]
        public string emailIntroductionIT { get; set; }

        [StringLength(512)]
        public string emailIntroductionEN { get; set; }

        [StringLength(512)]
        public string emailRepeatFR { get; set; }

        [StringLength(512)]
        public string emailRepeatIT { get; set; }

        [StringLength(512)]
        public string emailRepeatEN { get; set; }

        [StringLength(512)]
        public string emailContinueFR { get; set; }

        [StringLength(512)]
        public string emailContinueIT { get; set; }

        [StringLength(512)]
        public string emailContinueEN { get; set; }

        [StringLength(512)]
        public string emailPresentationFR { get; set; }

        [StringLength(512)]
        public string emailPresentationIT { get; set; }

        [StringLength(512)]
        public string emailPresentationEN { get; set; }

        [StringLength(512)]
        public string emailPortalFR { get; set; }

        [StringLength(512)]
        public string emailPortalIT { get; set; }

        [StringLength(512)]
        public string emailPortalEN { get; set; }

        [StringLength(512)]
        public string printRepeatFR { get; set; }

        [StringLength(512)]
        public string printRepeatIT { get; set; }

        [StringLength(512)]
        public string printRepeatEN { get; set; }

        [StringLength(512)]
        public string printContinueFR { get; set; }

        [StringLength(512)]
        public string printContinueIT { get; set; }

        [StringLength(512)]
        public string printContinueEN { get; set; }

        [StringLength(512)]
        public string printSalesPointFR { get; set; }

        [StringLength(512)]
        public string printSalesPointIT { get; set; }

        [StringLength(512)]
        public string printSalesPointEN { get; set; }

        [StringLength(512)]
        public string printPortalFR { get; set; }

        [StringLength(512)]
        public string printPortalIT { get; set; }

        [StringLength(512)]
        public string printPortalEN { get; set; }

        [StringLength(512)]
        public string printSignatureIT { get; set; }

        [StringLength(512)]
        public string printSignatureFR { get; set; }

        [StringLength(512)]
        public string printSignatureEN { get; set; }

        public int? rank { get; set; }

        public bool? night { get; set; }

        [StringLength(512)]
        public string printContinue2DE { get; set; }

        [StringLength(512)]
        public string printContinue2FR { get; set; }

        [StringLength(512)]
        public string printContinue2IT { get; set; }

        [StringLength(512)]
        public string prinCcontinue2EN { get; set; }

        [StringLength(512)]
        public string InmodoTCID { get; set; }

        public int? deltavista { get; set; }

        [StringLength(512)]
        public string PRINT_QR_Note_DE { get; set; }
        [StringLength(512)]
        public string PRINT_QR_Note_IT { get; set; }
        [StringLength(512)]
        public string PRINT_QR_Note_FR { get; set; }
        [StringLength(512)]
        public string PRINT_QR_Note_EN { get; set; }

        [StringLength(512)]
        public string PRINT_QR_TU_DE { get; set; }
        [StringLength(512)]
        public string PRINT_QR_TU_IT { get; set; }
        [StringLength(512)]
        public string PRINT_QR_TU_FR { get; set; }
        [StringLength(512)]
        public string PRINT_QR_TU_EN { get; set; }

        [StringLength(512)]
        public string PRINT_TU_URL { get; set; }

        public bool? enableSendIncidentBySMS { get; set; }

        public bool? enableSendIncidentByEmail { get; set; }
        public bool? enableUAboSearch { get; set; }

        [StringLength(50)]
        public string mwstEN { get; set; }

        [StringLength(50)]
        public string mwstDE { get; set; }

        [StringLength(50)]
        public string mwstFR { get; set; }

        [StringLength(50)]
        public string mwstIT { get; set; }

        public decimal? currencyExchangeCHF_EUR { get; set; }

        [StringLength(50)]
        public string domainForms { get; set; }

        [StringLength(50)]
        public string domainUsers { get; set; }
        
        public bool? enabledOnlinePayment { get; set; }
        public bool? enabledCashPayment { get; set; }

        public int loginExpiration { get; set; }

        [Column(TypeName = "text")]
        public string companyLogo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCompanies_Regions> tblCompanies_Regions { get; set; }

        public virtual tblRegion tblRegion { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<tblCompaniesTeam> tblCompaniesTeams { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<tblTeam> tblTeams { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblEmployer> tblEmployers { get; set; }
    }
}
