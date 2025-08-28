namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_BACKEND_FieldsConfiguration
    {
        public int id { get; set; }

        [StringLength(100)]
        public string viewName { get; set; }

        public string jsonFields { get; set; }

        public string jsonFields_FR { get; set; }

        public string jsonFields_IT { get; set; }

        public string jsonFields_EN { get; set; }
    }
}
