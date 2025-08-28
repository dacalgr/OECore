namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_FORMS_SurveyTemplates_Companies
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int templateId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int companyId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        public virtual tbl_CONFIG_Companies tbl_CONFIG_Companies { get; set; }

        public virtual tbl_FORMS_SurveyTemplates tbl_FORMS_SurveyTemplates { get; set; }
    }
}
