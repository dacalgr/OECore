using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenEyeBackendEntities.Context
{
    
        [Table("tblNewPinkExportRecords")]
        public partial class tblNewPinkExportRecord
        {
            [Key]
            public int Id { get; set; }

            public Guid ElementId { get; set; }
            public string ElementType { get; set; } //INCIDENT,TASK,TURN

            public string StoredId { get; set; }        //Use to replicate same incident. Must be calcualted from quitNo to avoid duplicates in SAP.

            public string QuitNo { get; set; }         //Only for incidents: original incident QuitNo
            public string TranslatedJson { get; set; }

            public string ExtractedJson { get; set; }

            public DateTime dtCreated { get; set; } = DateTime.UtcNow;

            public DateTime? dtSent { get; set; }

            public DateTime? dtUpdated { get; set; }

            [MaxLength(50)]
            public string Status { get; set; } = "pending";

            public string ResponseMessage { get; set; }

        }
    
}
