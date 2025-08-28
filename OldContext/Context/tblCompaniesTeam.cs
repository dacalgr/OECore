//namespace OpenEyeBackendEntities
//{
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Data.Entity.Spatial;

//    public partial class tblCompaniesTeam
//    {
//        public int id { get; set; }

//        public int? companyId { get; set; }

//        public int? teamId { get; set; }

//        [StringLength(4000)]
//        public string teamName { get; set; }

//        public virtual tblCompany tblCompany { get; set; }

//        public virtual tblTeam tblTeam { get; set; }
//    }
//}
