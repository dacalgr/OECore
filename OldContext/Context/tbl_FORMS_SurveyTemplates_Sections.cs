namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_FORMS_SurveyTemplates_Sections
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_FORMS_SurveyTemplates_Sections()
        {
            tbl_FORMS_Questions = new HashSet<tbl_FORMS_Questions>();
        }

        public int id { get; set; }

        public int surveyId { get; set; }

        public int sectionId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FORMS_Questions> tbl_FORMS_Questions { get; set; }

        public virtual tbl_FORMS_Sections tbl_FORMS_Sections { get; set; }

        public virtual tbl_FORMS_SurveyTemplates tbl_FORMS_SurveyTemplates { get; set; }
    }
}
