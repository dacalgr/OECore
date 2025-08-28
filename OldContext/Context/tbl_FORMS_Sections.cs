namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_FORMS_Sections
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_FORMS_Sections()
        {
            tbl_FORMS_SurveyTemplates_Sections = new HashSet<tbl_FORMS_SurveyTemplates_Sections>();
        }

        public int id { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public string name { get; set; }

        public bool required { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FORMS_SurveyTemplates_Sections> tbl_FORMS_SurveyTemplates_Sections { get; set; }
    }
}
