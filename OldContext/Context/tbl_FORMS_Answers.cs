namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_FORMS_Answers
    {
        public Guid id { get; set; }

        public int questionId { get; set; }

        [StringLength(255)]
        public string value { get; set; }

        public Guid surveyId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime dtCreated { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        public Guid? group { get; set; }

        public virtual tbl_FORMS_Questions tbl_FORMS_Questions { get; set; }

        public virtual tbl_FORMS_Surveys tbl_FORMS_Surveys { get; set; }
    }
}
