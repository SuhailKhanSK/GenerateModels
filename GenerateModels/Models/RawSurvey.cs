using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class RawSurvey
{
    public Guid Id { get; set; }

    public Guid RunId { get; set; }

    public DateTime DateTime { get; set; }

    public long? RigTimeOffset { get; set; }

    public bool ManualTimeOffsetFlag { get; set; }

    public double Depth { get; set; }

    public bool Enabled { get; set; }

    public double? Gx { get; set; }

    public double? Gy { get; set; }

    public double? Gz { get; set; }

    public double? Bx { get; set; }

    public double? By { get; set; }

    public double? Bz { get; set; }

    public double? Mwdinclination { get; set; }

    public double? MwdshortCollar { get; set; }

    public double? MwdlongCollar { get; set; }

    public double? SagInclination { get; set; }

    public int AzimuthType { get; set; }

    public double? Temperature { get; set; }

    public int PumpStatus { get; set; }

    public bool Deleted { get; set; }

    public string? Source { get; set; }

    public double Error1 { get; set; }

    public double Error2 { get; set; }

    public double Error3 { get; set; }

    public double Triac1 { get; set; }

    public double Triac2 { get; set; }

    public double Triac3 { get; set; }

    public double? Btotal { get; set; }

    public double? BtotalQcDelta { get; set; }

    public double? Gtotal { get; set; }

    public double? GtotalQcDelta { get; set; }

    public double? Dip { get; set; }

    public double? DipQcDelta { get; set; }

    public double? BtMeasured { get; set; }

    public double? DipMeasured { get; set; }

    public double? BvMeasured { get; set; }

    public double? BhMeasured { get; set; }

    public double? GxyzInclination { get; set; }

    public double? GxyInclination { get; set; }

    public double? GzInclination { get; set; }

    public double? Azimuth { get; set; }

    public double? Declination { get; set; }

    public double? Inclination { get; set; }

    public double? GridConvergence { get; set; }

    public double? Bg { get; set; }

    public double? Bh { get; set; }

    public string? LastEditedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public int ImportSource { get; set; }

    public Guid? SolutionId { get; set; }

    public virtual CorrectedSurvey? CorrectedSurvey { get; set; }

    public virtual ICollection<PmrsurveyBase> PmrsurveyBases { get; set; } = new List<PmrsurveyBase>();

    public virtual Run Run { get; set; } = null!;
}
