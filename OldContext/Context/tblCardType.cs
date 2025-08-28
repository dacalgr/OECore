namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblCardType
    {
        public int id { get; set; }

        public string text_it { get; set; }

        [StringLength(8)]
        public string code { get; set; }

        public string text_fr { get; set; }

        public string text_de { get; set; }
        public string text_en { get; set; }

        public int parentId { get; set; }

        public int? cardTypeId { get; set; }

        public bool zemis { get; set; }

        [Column(TypeName = "text")]
        public string companyId { get; set; }

        public int? rank { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtLastSQLIteImport { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtModified { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? dtCreated { get; set; }
    }
}
