namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_APPCONFIG_ActionsConfiguration
    {
        public int id { get; set; }

        public int actionId { get; set; }

        public string entityType { get; set; }

        public int entityId { get; set; }

        public int rank { get; set; }

        public string extraData { get; set; }

        public string appView { get; set; }
    }
}
