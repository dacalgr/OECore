using System.ComponentModel.DataAnnotations;

namespace OECore.Domain.Entities;

public class DispoLineStats
{
    public int Id { get; set; }
    
    [StringLength(50)]
    public string? LineNr { get; set; }
    
    [StringLength(10)]
    public string? ForegroundColor { get; set; }
    
    [StringLength(10)]
    public string? BackColor { get; set; }
    
    public long PassengersYear { get; set; }
    public long PassengersPercentMoFr0006 { get; set; }
    public long PassengersPercentMoFr0609 { get; set; }
    public long PassengersPercentMoFr0913 { get; set; }
    public long PassengersPercentMoFr1316 { get; set; }
    public long PassengersPercentMoFr1619 { get; set; }
    public long PassengersPercentMoFr1900 { get; set; }
    public long PassengersPercentSaSu0006 { get; set; }
    public long PassengersPercentSaSu0613 { get; set; }
    public long PassengersPercentSaSu1319 { get; set; }
    public long PassengersPercentSaSu1900 { get; set; }
    
    public long MinRelNrOfPassengersMoFr0006 { get; set; }
    public long MinRelNrOfPassengersMoFr0609 { get; set; }
    public long MinRelNrOfPassengersMoFr0913 { get; set; }
    public long MinRelNrOfPassengersMoFr1316 { get; set; }
    public long MinRelNrOfPassengersMoFr1619 { get; set; }
    public long MinRelNrOfPassengersMoFr1900 { get; set; }
    public long MinRelNrOfPassengersSaSu0006 { get; set; }
    public long MinRelNrOfPassengersSaSu0613 { get; set; }
    public long MinRelNrOfPassengersSaSu1319 { get; set; }
    public long MinRelNrOfPassengersSaSu1900 { get; set; }
    public long MinRelNrPassengersYear { get; set; }
    
    public double CompareValCdFeQ { get; set; }
    public DateTime? ControlStartDate { get; set; }
    
    public long NrOfIncidentsMoFr0006 { get; set; }
    public long NrOfIncidentsMoFr0609 { get; set; }
    public long NrOfIncidentsMoFr0913 { get; set; }
    public long NrOfIncidentsMoFr1316 { get; set; }
    public long NrOfIncidentsMoFr1619 { get; set; }
    public long NrOfIncidentsMoFr1900 { get; set; }
    public long NrOfIncidentsSaSu0006 { get; set; }
    public long NrOfIncidentsSaSu0613 { get; set; }
    public long NrOfIncidentsSaSu1319 { get; set; }
    public long NrOfIncidentsSaSu1900 { get; set; }
    public long NrOfIncidentsYear { get; set; }
    
    public long NrOfControledPassengersMoFr0006 { get; set; }
    public long NrOfControledPassengersMoFr0609 { get; set; }
    public long NrOfControledPassengersMoFr0913 { get; set; }
    public long NrOfControledPassengersMoFr1316 { get; set; }
    public long NrOfControledPassengersMoFr1619 { get; set; }
    public long NrOfControledPassengersMoFr1900 { get; set; }
    public long NrOfControledPassengersSaSu0006 { get; set; }
    public long NrOfControledPassengersSaSu0613 { get; set; }
    public long NrOfControledPassengersSaSu1319 { get; set; }
    public long NrOfControledPassengersSaSu1900 { get; set; }
    public long NrOfControledPassengersYear { get; set; }
    
    public double CgMoFr0006 { get; set; }
    public double CgMoFr0609 { get; set; }
    public double CgMoFr0913 { get; set; }
    public double CgMoFr1316 { get; set; }
    public double CgMoFr1619 { get; set; }
    public double CgMoFr1900 { get; set; }
    public double CgSaSu0006 { get; set; }
    public double CgSaSu0613 { get; set; }
    public double CgSaSu1319 { get; set; }
    public double CgSaSu1900 { get; set; }
    
    public double FeQMoFr0006 { get; set; }
    public double FeQMoFr0609 { get; set; }
    public double FeQMoFr0913 { get; set; }
    public double FeQMoFr1316 { get; set; }
    public double FeQMoFr1619 { get; set; }
    public double FeQMoFr1900 { get; set; }
    public double FeQSaSu0006 { get; set; }
    public double FeQSaSu0613 { get; set; }
    public double FeQSaSu1319 { get; set; }
    public double FeQSaSu1900 { get; set; }
    
    [StringLength(10)]
    public string? MoFr0006Icon { get; set; }
    
    [StringLength(10)]
    public string? MoFr0609Icon { get; set; }
    
    [StringLength(10)]
    public string? MoFr0913Icon { get; set; }
    
    [StringLength(10)]
    public string? MoFr1316Icon { get; set; }
    
    [StringLength(10)]
    public string? MoFr1619Icon { get; set; }
    
    [StringLength(10)]
    public string? MoFr1900Icon { get; set; }
    
    [StringLength(10)]
    public string? SaSu0006Icon { get; set; }
    
    [StringLength(10)]
    public string? SaSu0613Icon { get; set; }
    
    [StringLength(10)]
    public string? SaSu1319Icon { get; set; }
    
    [StringLength(10)]
    public string? SaSu1900Icon { get; set; }
    
    public double CgYear { get; set; }
    public double FeQYear { get; set; }
    
    [StringLength(10)]
    public string? YearIcon { get; set; }
    
    public double RelQMoFr0006 { get; set; }
    public double RelQMoFr0609 { get; set; }
    public double RelQMoFr0913 { get; set; }
    public double RelQMoFr1316 { get; set; }
    public double RelQMoFr1619 { get; set; }
    public double RelQMoFr1900 { get; set; }
    public double RelQSaSu0006 { get; set; }
    public double RelQSaSu0613 { get; set; }
    public double RelQSaSu1319 { get; set; }
    public double RelQSaSu1900 { get; set; }
    public double RelQYear { get; set; }
    
    public double PointsMoFr0006 { get; set; }
    public double PointsMoFr0609 { get; set; }
    public double PointsMoFr0913 { get; set; }
    public double PointsMoFr1316 { get; set; }
    public double PointsMoFr1619 { get; set; }
    public double PointsMoFr1900 { get; set; }
    public double PointsSaSu0006 { get; set; }
    public double PointsSaSu0613 { get; set; }
    public double PointsSaSu1319 { get; set; }
    public double PointsSaSu1900 { get; set; }
    public double PointsYear { get; set; }
    public double Points { get; set; }
    public int Rank { get; set; }
    
    public Guid LastControlId { get; set; }
    public DateTime? LastControlDateTimeFrom { get; set; }
    public long LastControlDuration { get; set; }
    public int NumberOfControlsLast30Days { get; set; }
    public int NumberOfControlsLast365Days { get; set; }
    public int NumberOfControlsSinceStartOfYear { get; set; }
}
