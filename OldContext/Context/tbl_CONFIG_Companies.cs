namespace OpenEyeBackendEntities
{
    using OpenEyeBackendEntities.Context;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Companies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_Companies()
        {
            tbl_CONFIG_CodeScanTypes_Companies = new HashSet<tbl_CONFIG_CodeScanTypes_Companies>();
            tbl_FORMS_Surveys = new HashSet<tbl_FORMS_Surveys>();
            tbl_FORMS_SurveyTemplates_Companies = new HashSet<tbl_FORMS_SurveyTemplates_Companies>();
            tbl_TICKETING_Tickets = new HashSet<tbl_TICKETING_Tickets>();
            tblIncidents = new HashSet<tblIncident>();
            tblTasks = new HashSet<tblTask>();
            tblUsers_Companies = new HashSet<tblUsers_Companies>();
            tblControlBases = new HashSet<tblControlBase>();
            tblUsers = new HashSet<tblUser>();
            tbl_CONFIG_Behaviours = new HashSet<tbl_CONFIG_Behaviours>();
            tbl_CONFIG_CardTypes = new HashSet<tbl_CONFIG_CardTypes>();
            tbl_CONFIG_CommentsTemplates = new HashSet<tbl_CONFIG_CommentsTemplates>();
            tbl_CONFIG_Profiles = new HashSet<tbl_CONFIG_Profiles>();
            tbl_CONFIG_Regions = new HashSet<tbl_CONFIG_Regions>();
            tbl_CONFIG_OthersCategories = new HashSet<tbl_CONFIG_OthersCategories>();
            tbl_CONFIG_ReasonsCategories = new HashSet<tbl_CONFIG_ReasonsCategories>();
            tbl_CONFIG_ReasonsSubcategories = new HashSet<tbl_CONFIG_ReasonsSubcategories>();
            tbl_CONFIG_Routes = new HashSet<tbl_CONFIG_Routes>();
            tbl_CONFIG_EmailTexts = new HashSet<tbl_CONFIG_EmailTexts>();
            tbl_TICKETING_Products = new HashSet<tbl_TICKETING_Products>();
            tblBlackListFiles = new HashSet<tblBlackListFile>();
            tblDeviceContact = new HashSet<tblDeviceContact>();

            tbl_CONFIG_ReasonsCategories_TicketControl = new HashSet<tbl_CONFIG_ReasonsCategories>();
            tbl_CONFIG_ReasonsCategories_ExternerTU = new HashSet<tbl_CONFIG_ReasonsCategories>();
            tblCMSUsers = new HashSet<tblUser>();
            
        }

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
        public string VoeVTUCode { get; set; }

        [StringLength(50)]
        public string VoeTarifVerbundCode { get; set; }

        //Do not show in CMS and do not use in app. Remains for backwards comaptibility
        public bool? AddQR { get; set; }

        //Text (CHE-116.287.954 MWST)
        [StringLength(50)]
        public string mwst { get; set; }
        [StringLength(50)]
        public string mwst_FR { get; set; }
        [StringLength(50)]
        public string mwst_IT { get; set; }
        [StringLength(50)]
        public string mwst_EN { get; set; }

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

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }

        [StringLength(512)]
        public string printLogo { get; set; }

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

        [StringLength(50)]
        public string shortName_old { get; set; }

        public bool? enableSendIncidentBySMS { get; set; }

        public bool? enableSendIncidentByEmail { get; set; }

        public bool? enableUAboSearch { get; set; }

        //Text (* inkl. 7.7% MWST)
        [StringLength(50)]
        public string mwstEN { get; set; }

        [StringLength(50)]
        public string mwstDE { get; set; }

        [StringLength(50)]
        public string mwstFR { get; set; }

        [StringLength(50)]
        public string mwstIT { get; set; }

        public decimal? currencyExchangeCHF_EUR { get; set; }

        public int? trafficTypeId { get; set; }

        [StringLength(50)]
        public string domainForms { get; set; }

        public int? cleanJobId { get; set; }

        public bool? enabledOnlinePayment { get; set; }
        public bool? enabledCashPayment { get; set; }

        public int loginExpiration { get; set; }

        [Column(TypeName = "text")]
        public string companyLogo { get; set; }

        [Column(TypeName = "text")]
        public string externerTUQR { get; set; }
        [StringLength(500)]
        public string web { get; set; }


        //NOVA Fields
        [StringLength(255)]
        public string NOVAAllowedTicketIds { get;set; }
        [StringLength(15)]
        public string NOVASellPlace { get; set; }
        public string NOVAVertriebsPunkt{ get; set; }
        public string NOVALeistungsVermittler{ get; set; }
        public bool EnableNOVATickets { get; set; }
        public string ProductBasedSellingStructure { get; set; }

        //NewPink
        public bool useNewAPI { get; set; }

        public virtual tbl_CONFIG_CleanJobs tbl_CONFIG_CleanJobs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_CodeScanTypes_Companies> tbl_CONFIG_CodeScanTypes_Companies { get; set; }

        public virtual tbl_CONFIG_TrafficTypes tbl_CONFIG_TrafficTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblDeviceContact> tblDeviceContact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FORMS_Surveys> tbl_FORMS_Surveys { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FORMS_SurveyTemplates_Companies> tbl_FORMS_SurveyTemplates_Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TICKETING_Tickets> tbl_TICKETING_Tickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblIncident> tblIncidents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTask> tblTasks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUsers_Companies> tblUsers_Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblControlBase> tblControlBases { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUser> tblUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Behaviours> tbl_CONFIG_Behaviours { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_CardTypes> tbl_CONFIG_CardTypes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_CommentsTemplates> tbl_CONFIG_CommentsTemplates { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Profiles> tbl_CONFIG_Profiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Regions> tbl_CONFIG_Regions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_OthersCategories> tbl_CONFIG_OthersCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_ReasonsCategories> tbl_CONFIG_ReasonsCategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_ReasonsSubcategories> tbl_CONFIG_ReasonsSubcategories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_ReasonsCategories> tbl_CONFIG_ReasonsCategories_TicketControl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_ReasonsCategories> tbl_CONFIG_ReasonsCategories_ExternerTU { get; set; }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Routes> tbl_CONFIG_Routes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_EmailTexts> tbl_CONFIG_EmailTexts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_TICKETING_Products> tbl_TICKETING_Products { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBlackListFile> tblBlackListFiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DOCBOX_Folders> tbl_DOCBOX_FoldersWrite { get; set; }


        public virtual ICollection<tblUser> tblCMSUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies_NOVA_ProductData> CompanyProducts { get; set; }
    }
}
