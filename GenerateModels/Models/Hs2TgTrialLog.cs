using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Hs2TgTrialLog
{
    public Guid Id { get; set; }

    public Guid RangingDeterminationId { get; set; }

    public bool Deleted { get; set; }

    public DateTime CalculationDateTime { get; set; }

    public double AverageInclination { get; set; }

    public double ApparentAzimuth { get; set; }

    public double Highside2Target { get; set; }

    public double Highside2TargetOtherPolarity { get; set; }

    public double CorrectedCoefficient { get; set; }

    public int SelectedSurveys { get; set; }

    public double FinalResult { get; set; }

    public double ModelBeg { get; set; }

    public double ModelBeh { get; set; }

    public double ShallowestDepth { get; set; }

    public double DeepestDepth { get; set; }

    public virtual RangingDetermination RangingDetermination { get; set; } = null!;
}
