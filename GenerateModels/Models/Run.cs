using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Run
{
    public Guid Id { get; set; }

    public Guid WellId { get; set; }

    public string? RunNumber { get; set; }

    public double StartDepth { get; set; }

    public double EndDepth { get; set; }

    public int ToolType { get; set; }

    public string? SerialNumber { get; set; }

    public double NonMagAboveSensor { get; set; }

    public double NonMagBelowSensor { get; set; }

    public double DistanceToBit { get; set; }

    public DateTime StartTime { get; set; }

    public string? SurveyDescription { get; set; }

    public int PrimaryOrSecondary { get; set; }

    public bool IsPending { get; set; }

    public string? LastEditedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public DateTime CreatedTime { get; set; }

    public double? ToolfaceOffset { get; set; }

    public bool Deleted { get; set; }

    public double InclinationTolerance { get; set; }

    public double AzimuthLongCollarTolerance { get; set; }

    public DateTime EndTime { get; set; }

    public int SagCorrectionLevel { get; set; }

    public string? Comments { get; set; }

    public virtual ICollection<RawSurvey> RawSurveys { get; set; } = new List<RawSurvey>();

    public virtual ICollection<Shortsurvey> Shortsurveys { get; set; } = new List<Shortsurvey>();

    public virtual ICollection<Solution> Solutions { get; set; } = new List<Solution>();

    public virtual Well Well { get; set; } = null!;
}
