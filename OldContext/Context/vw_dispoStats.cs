namespace OpenEyeBackendEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_dispoStats
    {
        public long? id { get; set; }

        [StringLength(50)]
        public string LineNr { get; set; }

        [StringLength(50)]
        public string LineNr_TU { get; set; }

        [StringLength(50)]
        public string AccessProfile { get; set; }

        [StringLength(10)]
        public string ForegroundColor { get; set; }

        [StringLength(10)]
        public string BackColor { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersYear { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersPercent_MoFr_0006 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersPercent_MoFr_0609 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersPercent_MoFr_0913 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersPercent_MoFr_1316 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersPercent_MoFr_1619 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersPercent_MoFr_1900 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersPercent_SaSu_0006 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersPercent_SaSu_0613 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersPercent_SaSu_1319 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long PassengersPercent_SaSu_1900 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrOfPassengers_MoFr_0006 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrOfPassengers_MoFr_0609 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrOfPassengers_MoFr_0913 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrOfPassengers_MoFr_1316 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrOfPassengers_MoFr_1619 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrOfPassengers_MoFr_1900 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrOfPassengers_SaSu_0006 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrOfPassengers_SaSu_0613 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrOfPassengers_SaSu_1319 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrOfPassengers_SaSu_1900 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MinRelNrPassengers_Year { get; set; }

        public double CompareVal_Cd_FeQ { get; set; }


        [Column(TypeName = "datetime2")]
        public DateTime? ControlStartDate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_0006 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_0609 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_0913 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_1316 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_1619 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_1900 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_SaSu_0006 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_SaSu_0613 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_SaSu_1319 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_SaSu_1900 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_Year { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_0006 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_0609 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_0913 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_1316 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_1619 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_1900 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_SaSu_0006 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_SaSu_0613 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_SaSu_1319 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_SaSu_1900 { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_Year { get; set; }

        public double CG_MoFr_0006 { get; set; }

        public double CG_MoFr_0609 { get; set; }

        public double CG_MoFr_0913 { get; set; }

        public double CG_MoFr_1316 { get; set; }

        public double CG_MoFr_1619 { get; set; }

        public double CG_MoFr_1900 { get; set; }

        public double CG_SaSu_0006 { get; set; }

        public double CG_SaSu_0613 { get; set; }

        public double CG_SaSu_1319 { get; set; }

        public double CG_SaSu_1900 { get; set; }

        public double FeQ_MoFr_0006 { get; set; }

        public double FeQ_MoFr_0609 { get; set; }

        public double FeQ_MoFr_0913 { get; set; }

        public double FeQ_MoFr_1316 { get; set; }

        public double FeQ_MoFr_1619 { get; set; }

        public double FeQ_MoFr_1900 { get; set; }

        public double FeQ_SaSu_0006 { get; set; }

        public double FeQ_SaSu_0613 { get; set; }

        public double FeQ_SaSu_1319 { get; set; }

        public double FeQ_SaSu_1900 { get; set; }

        [StringLength(10)]
        public string MoFr_0006_Icon { get; set; }

        [StringLength(10)]
        public string MoFr_0609_Icon { get; set; }

        [StringLength(10)]
        public string MoFr_0913_Icon { get; set; }

        [StringLength(10)]
        public string MoFr_1316_Icon { get; set; }

        [StringLength(10)]
        public string MoFr_1619_Icon { get; set; }

        [StringLength(10)]
        public string MoFr_1900_Icon { get; set; }

        [StringLength(10)]
        public string SaSu_0006_Icon { get; set; }

        [StringLength(10)]
        public string SaSu_0613_Icon { get; set; }

        [StringLength(10)]
        public string SaSu_1319_Icon { get; set; }

        [StringLength(10)]
        public string SaSu_1900_Icon { get; set; }

        public double CG_Year { get; set; }

        public double FeQ_Year { get; set; }

        [StringLength(10)]
        public string Year_Icon { get; set; }

        public double RelQ_MoFr_0006 { get; set; }

        public double RelQ_MoFr_0609 { get; set; }

        public double RelQ_MoFr_0913 { get; set; }

        public double RelQ_MoFr_1316 { get; set; }

        public double RelQ_MoFr_1619 { get; set; }

        public double RelQ_MoFr_1900 { get; set; }

        public double RelQ_SaSu_0006 { get; set; }

        public double RelQ_SaSu_0613 { get; set; }

        public double RelQ_SaSu_1319 { get; set; }

        public double RelQ_SaSu_1900 { get; set; }

        public double RelQ_Year { get; set; }

        public double Points_MoFr_0006 { get; set; }

        public double Points_MoFr_0609 { get; set; }

        public double Points_MoFr_0913 { get; set; }

        public double Points_MoFr_1316 { get; set; }

        public double Points_MoFr_1619 { get; set; }

        public double Points_MoFr_1900 { get; set; }

        public double Points_SaSu_0006 { get; set; }

        public double Points_SaSu_0613 { get; set; }

        public double Points_SaSu_1319 { get; set; }

        public double Points_SaSu_1900 { get; set; }

        public double Points_Year { get; set; }

        public double Points { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rank { get; set; }

        public double Points_CG_MoFr_0006 { get; set; }

        public double Points_CG_MoFr_0609 { get; set; }

        public double Points_CG_MoFr_0913 { get; set; }

        public double Points_CG_MoFr_1316 { get; set; }

        public double Points_CG_MoFr_1619 { get; set; }

        public double Points_CG_MoFr_1900 { get; set; }

        public double Points_CG_SaSu_0006 { get; set; }

        public double Points_CG_SaSu_0613 { get; set; }

        public double Points_CG_SaSu_1319 { get; set; }

        public double Points_CG_SaSu_1900 { get; set; }

        public double Points_CG_Year { get; set; }

        public double Points_FeQ_MoFr_0006 { get; set; }

        public double Points_FeQ_MoFr_0609 { get; set; }

        public double Points_FeQ_MoFr_0913 { get; set; }

        public double Points_FeQ_MoFr_1316 { get; set; }

        public double Points_FeQ_MoFr_1619 { get; set; }

        public double Points_FeQ_MoFr_1900 { get; set; }

        public double Points_FeQ_SaSu_0006 { get; set; }

        public double Points_FeQ_SaSu_0613 { get; set; }

        public double Points_FeQ_SaSu_1319 { get; set; }

        public double Points_FeQ_SaSu_1900 { get; set; }

        public double Points_FeQ_Year { get; set; }

        public int? dtDeleted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_0006_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_0609_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_0913_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_1316_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_1619_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_MoFr_1900_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_SaSu_0006_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_SaSu_0613_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_SaSu_1319_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_SaSu_1900_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_0006_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_0609_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_0913_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_1316_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_1619_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_MoFr_1900_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_SaSu_0006_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_SaSu_0613_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_SaSu_1319_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_SaSu_1900_30days { get; set; }

        public double CG_MoFr_0006_30days { get; set; }

        public double CG_MoFr_0609_30days { get; set; }

        public double CG_MoFr_0913_30days { get; set; }

        public double CG_MoFr_1316_30days { get; set; }

        public double CG_MoFr_1619_30days { get; set; }

        public double CG_MoFr_1900_30days { get; set; }

        public double CG_SaSu_0006_30days { get; set; }

        public double CG_SaSu_0613_30days { get; set; }

        public double CG_SaSu_1319_30days { get; set; }

        public double CG_SaSu_1900_30days { get; set; }

        public double FeQ_MoFr_0006_30days { get; set; }

        public double FeQ_MoFr_0609_30days { get; set; }

        public double FeQ_MoFr_0913_30days { get; set; }

        public double FeQ_MoFr_1316_30days { get; set; }

        public double FeQ_MoFr_1619_30days { get; set; }

        public double FeQ_MoFr_1900_30days { get; set; }

        public double FeQ_SaSu_0006_30days { get; set; }

        public double FeQ_SaSu_0613_30days { get; set; }

        public double FeQ_SaSu_1319_30days { get; set; }

        public double FeQ_SaSu_1900_30days { get; set; }

        [StringLength(10)]
        public string MoFr_0006_Icon_30days { get; set; }

        [StringLength(10)]
        public string MoFr_0609_Icon_30days { get; set; }

        [StringLength(10)]
        public string MoFr_0913_Icon_30days { get; set; }

        [StringLength(10)]
        public string MoFr_1316_Icon_30days { get; set; }

        [StringLength(10)]
        public string MoFr_1619_Icon_30days { get; set; }

        [StringLength(10)]
        public string MoFr_1900_Icon_30days { get; set; }

        [StringLength(10)]
        public string SaSu_0006_Icon_30days { get; set; }

        [StringLength(10)]
        public string SaSu_0613_Icon_30days { get; set; }

        [StringLength(10)]
        public string SaSu_1319_Icon_30days { get; set; }

        [StringLength(10)]
        public string SaSu_1900_Icon_30days { get; set; }

        public double RelQ_MoFr_0006_30days { get; set; }

        public double RelQ_MoFr_0609_30days { get; set; }

        public double RelQ_MoFr_0913_30days { get; set; }

        public double RelQ_MoFr_1316_30days { get; set; }

        public double RelQ_MoFr_1619_30days { get; set; }

        public double RelQ_MoFr_1900_30days { get; set; }

        public double RelQ_SaSu_0006_30days { get; set; }

        public double RelQ_SaSu_0613_30days { get; set; }

        public double RelQ_SaSu_1319_30days { get; set; }

        public double RelQ_SaSu_1900_30days { get; set; }

        public double Points_MoFr_0006_30days { get; set; }

        public double Points_MoFr_0609_30days { get; set; }

        public double Points_MoFr_0913_30days { get; set; }

        public double Points_MoFr_1316_30days { get; set; }

        public double Points_MoFr_1619_30days { get; set; }

        public double Points_MoFr_1900_30days { get; set; }

        public double Points_SaSu_0006_30days { get; set; }

        public double Points_SaSu_0613_30days { get; set; }

        public double Points_SaSu_1319_30days { get; set; }

        public double Points_SaSu_1900_30days { get; set; }

        public double Points_CG_MoFr_0006_30days { get; set; }

        public double Points_CG_MoFr_0609_30days { get; set; }

        public double Points_CG_MoFr_0913_30days { get; set; }

        public double Points_CG_MoFr_1316_30days { get; set; }

        public double Points_CG_MoFr_1619_30days { get; set; }

        public double Points_CG_MoFr_1900_30days { get; set; }

        public double Points_CG_SaSu_0006_30days { get; set; }

        public double Points_CG_SaSu_0613_30days { get; set; }

        public double Points_CG_SaSu_1319_30days { get; set; }

        public double Points_CG_SaSu_1900_30days { get; set; }

        public double Points_FeQ_MoFr_0006_30days { get; set; }

        public double Points_FeQ_MoFr_0609_30days { get; set; }

        public double Points_FeQ_MoFr_0913_30days { get; set; }

        public double Points_FeQ_MoFr_1316_30days { get; set; }

        public double Points_FeQ_MoFr_1619_30days { get; set; }

        public double Points_FeQ_MoFr_1900_30days { get; set; }

        public double Points_FeQ_SaSu_0006_30days { get; set; }

        public double Points_FeQ_SaSu_0613_30days { get; set; }

        public double Points_FeQ_SaSu_1319_30days { get; set; }

        public double Points_FeQ_SaSu_1900_30days { get; set; }

        public double Points_Year_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfIncidents_Year_30days { get; set; }

        public double CG_Year_30days { get; set; }

        [StringLength(10)]
        public string Year_Icon_30days { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long NrOfControledPassengers_Year_30days { get; set; }

        public double FeQ_Year_30days { get; set; }

        public double RelQ_Year_30days { get; set; }

        public double Points_CG_Year_30days { get; set; }

        public double Points_FeQ_Year_30days { get; set; }

    }
}
