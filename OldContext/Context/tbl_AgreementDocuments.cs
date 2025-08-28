namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_AgreementDocuments
    {
        public int id { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string title_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string title_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string title_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string description_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string description_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string description_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string link_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string link_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string link_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string document_link_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string document_link_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string document_link_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string question1_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string question1_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string question1_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string question2_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string question2_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string question2_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string question3_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string question3_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string question3_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string answers1_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string answers1_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string answers1_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string answers2_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string answers2_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string answers2_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string answers3_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string answers3_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string answers3_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string correctAnswer1_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string correctAnswer1_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string correctAnswer1_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string correctAnswer2_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string correctAnswer2_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string correctAnswer2_FR { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string correctAnswer3_DE { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string correctAnswer3_IT { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string correctAnswer3_FR { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime updateTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }
    }
}
