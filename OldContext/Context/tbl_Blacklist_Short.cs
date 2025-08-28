//namespace OpenEyeBackendEntities
//{
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    using System.ComponentModel.DataAnnotations.Schema;
//    using System.Data.Entity.Spatial;

//    public partial class tbl_Blacklist_Short
//    {
//        [Key]
//        [Column(Order = 0)]
//        public int id { get; set; }

//        [StringLength(100)]
//        public string name { get; set; }

//        [StringLength(100)]
//        public string vorname { get; set; }

//        public bool? blacklisted { get; set; }

//        [StringLength(1024)]
//        public string comments_de { get; set; }

//        [StringLength(1024)]
//        public string comments_fr { get; set; }

//        [StringLength(1024)]
//        public string comments_it { get; set; }

//        public long? birthdate { get; set; }

//        [Key]
//        [Column(Order = 1)]
//        [DatabaseGenerated(DatabaseGeneratedOption.None)]
//        public long created { get; set; }

//        [Column(TypeName = "date")]
//        public DateTime? expirationDate { get; set; }

//        [StringLength(1014)]
//        public string comments { get; set; }

//        public int? fileId { get; set; }

//        [Column(TypeName = "datetime2")]
//        public DateTime? createdAt { get; set; }

//        [Column(TypeName = "datetime2")]
//        public DateTime? updatedAt { get; set; }

//        [Column(TypeName = "datetime2")]
//        public DateTime? deletetAt { get; set; }

//        [Column(TypeName = "datetime2")]
//        public DateTime? lastImport { get; set; }
//    }
//}
