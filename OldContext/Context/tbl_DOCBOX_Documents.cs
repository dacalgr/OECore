namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DOCBOX_Documents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_DOCBOX_Documents()
        {
            tbl_DOCBOX_DocumentsUsersRead = new HashSet<tbl_DOCBOX_DocumentsUsersRead>();
            tbl_CONFIG_Profiles = new HashSet<tbl_CONFIG_Profiles>();
            //tbl_DOCBOX_Tags = new HashSet<tbl_DOCBOX_Tags>();
            tbl_DOCBOX_Favorites = new HashSet<tbl_DOCBOX_Favorites>();
        }

        public int id { get; set; }

        public int? folderID { get; set; }

        public int? langID { get; set; }

        [StringLength(4000)]
        public string identifier { get; set; }

        [StringLength(1000)]
        public string name { get; set; }

        [StringLength(1000)]
        public string fileName { get; set; }

        [StringLength(4000)]
        public string urlDownload { get; set; }

        [StringLength(10)]
        public string type { get; set; }

        [StringLength(4000)]
        public string description { get; set; }

        public bool? requestReading { get; set; }

        public long? size { get; set; }

        public bool? flagOffline { get; set; }

        public bool? flagWasOffline { get; set; }

        public bool? flagWasOnline { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? validFrom { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? validTo { get; set; }

        public bool? hiddenInList { get; set; }

        public int? cpns_message { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dateCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dateModified { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dateDeleted { get; set; }

        [StringLength(50)]
        public string userModified { get; set; }

        public virtual tbl_DOCBOX_Folders tbl_DOCBOX_Folders { get; set; }

        public virtual tblLanguage tblLanguage { get; set; }

        public virtual int priority { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DOCBOX_DocumentsUsersRead> tbl_DOCBOX_DocumentsUsersRead { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Profiles> tbl_CONFIG_Profiles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<tbl_DOCBOX_Tags> tbl_DOCBOX_Tags { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DOCBOX_Favorites> tbl_DOCBOX_Favorites { get; set; }
    }
}
