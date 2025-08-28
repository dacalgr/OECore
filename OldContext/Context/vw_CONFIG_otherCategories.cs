namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_CONFIG_otherCategories
    {
        public string Hierarchy { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public string text_it { get; set; }

        public string text_fr { get; set; }

        public string text_de { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int parentId { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int categoryId { get; set; }

        public int? rank { get; set; }

        [Column(TypeName = "text")]
        public string langRef { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }
    }
}
