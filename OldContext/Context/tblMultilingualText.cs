namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblMultilingualText
    {
        public int id { get; set; }

        [StringLength(30)]
        public string key { get; set; }

        [StringLength(3000)]
        public string text_de { get; set; }

        [StringLength(3000)]
        public string text_fr { get; set; }

        [StringLength(3000)]
        public string text_it { get; set; }

        [StringLength(3000)]
        public string text_en { get; set; }
    }
}
