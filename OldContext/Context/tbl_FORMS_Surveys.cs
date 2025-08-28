namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_FORMS_Surveys
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_FORMS_Surveys()
        {
            tbl_FORMS_Answers = new HashSet<tbl_FORMS_Answers>();
        }

        public Guid id { get; set; }

        public int templateId { get; set; }

        public int userId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtClosed { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtUploaded { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        public bool sync { get; set; }

        public int companyId { get; set; }

        public int regionId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtExported { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtBalanced { get; set; }

        public virtual tbl_CONFIG_Companies tbl_CONFIG_Companies { get; set; }

        public virtual tbl_CONFIG_Regions tbl_CONFIG_Regions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_FORMS_Answers> tbl_FORMS_Answers { get; set; }

        public virtual tbl_FORMS_SurveyTemplates tbl_FORMS_SurveyTemplates { get; set; }
    }
}
