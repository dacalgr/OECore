namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CONFIG_Profiles
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_CONFIG_Profiles()
        {
            tbl_DISPO_LineStats = new HashSet<tbl_DISPO_LineStats>();
            tbl_DISPO_LineStats_Temp = new HashSet<tbl_DISPO_LineStats_Temp>();
            tblUsers_Profiles = new HashSet<tblUsers_Profiles>();
            tbl_CONFIG_Companies = new HashSet<tbl_CONFIG_Companies>();
            tbl_CONFIG_DispoStats = new HashSet<tbl_CONFIG_DispoStats>();
            tbl_DOCBOX_Documents = new HashSet<tbl_DOCBOX_Documents>();
            tbl_DOCBOX_Folders = new HashSet<tbl_DOCBOX_Folders>();
            //tbl_DOCBOX_FoldersWrite = new HashSet<tbl_DOCBOX_Folders>();
            tblContacts = new HashSet<tblContact>();
        }

        public int id { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string shortName { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DISPO_LineStats> tbl_DISPO_LineStats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DISPO_LineStats_Temp> tbl_DISPO_LineStats_Temp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUsers_Profiles> tblUsers_Profiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_DispoStats> tbl_CONFIG_DispoStats { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DOCBOX_Documents> tbl_DOCBOX_Documents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DOCBOX_Folders> tbl_DOCBOX_Folders { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<tbl_DOCBOX_Folders> tbl_DOCBOX_FoldersWrite { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblContact> tblContacts { get; set; }
    }
}
