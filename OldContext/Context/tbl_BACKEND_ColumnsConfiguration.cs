namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_BACKEND_ColumnsConfiguration
    {
        public int id { get; set; }

        [StringLength(50)]
        public string userID { get; set; }

        [StringLength(100)]
        public string tableName { get; set; }

        [StringLength(4000)]
        public string visibleColumns { get; set; }
    }
}
