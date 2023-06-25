using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class DpatrialLog
{
    public Guid Id { get; set; }

    public Guid RangingDeterminationId { get; set; }

    public bool Deleted { get; set; }

    public DateTime CalculationDateTime { get; set; }

    public double MinimumDepth { get; set; }

    public double MaximumDepth { get; set; }

    public double Bg { get; set; }

    public double Bh { get; set; }

    public double Inclination0 { get; set; }

    public double Azimuth0 { get; set; }

    public double Declination { get; set; }

    public double Casing { get; set; }

    public double CasingDiameter { get; set; }

    public double MeasuredDepth { get; set; }

    public double Range { get; set; }

    public double Az2Tg { get; set; }

    public double Hs2tg { get; set; }

    public double NorthingShift { get; set; }

    public double EastingShift { get; set; }

    public double SurveyMeasuredDepth { get; set; }

    public double SurveyInclination { get; set; }

    public double SurveyAzimuth { get; set; }

    public double Hss { get; set; }

    public double Rss { get; set; }

    public double DrillingNorth { get; set; }

    public double DrillingEast { get; set; }

    public double DrillingTvd { get; set; }

    public double TargetNorth { get; set; }

    public double TargetEast { get; set; }

    public double TargetTvd { get; set; }

    public virtual RangingDetermination RangingDetermination { get; set; } = null!;
}
