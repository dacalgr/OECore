namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class tblUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblUser()
        {
            tbl_DOCBOX_DocumentsUsersRead = new HashSet<tbl_DOCBOX_DocumentsUsersRead>();
            tblUsers_Companies = new HashSet<tblUsers_Companies>();
            tblUsers_Profiles = new HashSet<tblUsers_Profiles>();
            tbl_DOCBOX_Favorites = new HashSet<tbl_DOCBOX_Favorites>();
            tblCMSCompanies = new HashSet<tbl_CONFIG_Companies>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string personalNumber { get; set; }

        public DateTime? activeFrom { get; set; }

        public DateTime? activeTo { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? lastActiveToUpdate { get; set; }

        //USE employerOF
        public int? employer { get; set; }

        public int? controlBase { get; set; }

        public int? language { get; set; }

        public DateTime? dtCreated { get; set; }

        public DateTime? dtModified { get; set; }

        public DateTime? dtDeleted { get; set; }

        public DateTime? readFromSP { get; set; }

        public int? extranetId { get; set; }

        [StringLength(50)]
        public string theme { get; set; }

        [StringLength(500)]
        public string PU { get; set; }

        public bool alphaEnabled { get; set; }

        public bool ticketTimeCheckEnabled { get; set; }

        [StringLength(50)]
        public string voeVTUCode { get; set; }

        public int? dashboardId { get; set; }

        public bool? protectedUser { get; set; }

        public int? employerOf { get; set; }

        public bool forceResetPassword { get; set; }

        [StringLength(64)]
        public string hashPassword { get; set; }

        [StringLength(64)]
        public string hashPasswordSalt { get; set; }


        public int? contactId { get; set; }

        public bool belegeAusstellbar { get; set; }

        public bool vorfallAusloesbar { get; set; }

        public DateTime? signedTimestamp { get; set; }
        public DateTime? lastPasswordChange { get; set; }

        [StringLength(64)]
        public string lastLoginDevice { get; set; }

        public bool isBackendUser { get; set; }     //Will be set by cron process

        public DateTime? lastLogin { get; set; }
        public DateTime? lastBalance { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? requestToDelete { get; set; }
        public int? requestToDeleteBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? deletedAfterRequest { get; set; }
        public int? deletedAfterRequestBy { get; set; }

        public bool isSupervisor { get; set; }

        public virtual tbl_CONFIG_Companies tbl_CONFIG_Companies { get; set; }

        public virtual tbl_CONFIG_Dashboards tbl_CONFIG_Dashboards { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DOCBOX_DocumentsUsersRead> tbl_DOCBOX_DocumentsUsersRead { get; set; }

        public virtual tblContact tblContact { get; set; }

        public virtual tblControlBase tblControlBas { get; set; }

        public virtual tblEmployer tblEmployer { get; set; }

        public virtual tblLanguage tblLanguage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUsers_Companies> tblUsers_Companies { get; set; }

        public virtual tblUsers_Favorites tblUsers_Favorites { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUsers_Profiles> tblUsers_Profiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DOCBOX_Favorites> tbl_DOCBOX_Favorites { get; set; }

        public virtual ICollection<tbl_CONFIG_Companies> tblCMSCompanies { get; set; }

        public virtual ICollection<tbl_MONITOR_CMSUserRequest> requestUsers { get; set; }
        public virtual ICollection<tbl_MONITOR_CMSUserRequest> validationUsers { get; set; }

        [ForeignKey("requestToDeleteBy")]
        public virtual tblUser requestToDeleteByUser { get; set; }

    }
}
