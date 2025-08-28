namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_APPCONFIG_Actions
    {
        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(4000)]
        public string extraData { get; set; }  //Default Values for configurable fields by User or Company

        [StringLength(4000)]
        public string configurationData { get; set; }   //Values needed to properly work not dependant of User or Conpany

        [StringLength(100)]
        public string action { get; set; }      //Name of the task to be set when sending back to Server

        public int rank { get; set; }       //Default order

        [Column(TypeName = "text")]
        public string icon { get; set; }
        public string text_de {get; set; }
        public string text_it { get; set; }
        public string text_fr { get; set; }
        public string text_en { get; set; }

        public string appView { get; set; }
    }
}
