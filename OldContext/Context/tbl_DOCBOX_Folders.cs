namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_DOCBOX_Folders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_DOCBOX_Folders()
        {
            tbl_DOCBOX_Documents = new HashSet<tbl_DOCBOX_Documents>();
            tbl_DOCBOX_FoldersChildren = new HashSet<tbl_DOCBOX_Folders>();
            tbl_CONFIG_Profiles = new HashSet<tbl_CONFIG_Profiles>();
            tbl_CONFIG_Companies_Write = new HashSet<tbl_CONFIG_Companies>();
        }

        public int id { get; set; }

        public int? parentId { get; set; }

        [StringLength(500)]
        public string name { get; set; }

        [StringLength(1000)]
        public string virtualPath { get; set; }

        [StringLength(100)]
        public string hierarchy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DOCBOX_Documents> tbl_DOCBOX_Documents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_DOCBOX_Folders> tbl_DOCBOX_FoldersChildren { get; set; }

        public virtual tbl_DOCBOX_Folders tbl_DOCBOX_FolderParent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Profiles> tbl_CONFIG_Profiles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_CONFIG_Companies> tbl_CONFIG_Companies_Write { get; set; }
    }
}
