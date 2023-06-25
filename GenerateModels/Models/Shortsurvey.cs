using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Shortsurvey
{
    public Guid Id { get; set; }

    public Guid RunId { get; set; }

    public DateTime DateTime { get; set; }

    public double Depth { get; set; }

    public double? Inclination { get; set; }

    public double? Azimuth { get; set; }

    public double? Gtotal { get; set; }

    public double? Btotal { get; set; }

    public int SurveyType { get; set; }

    public string? LastEditedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public DateTime CreatedTime { get; set; }

    public double? NorthSouth { get; set; }

    public double? EastWest { get; set; }

    public double? Easting { get; set; }

    public double? Northing { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public double? Tvd { get; set; }

    public double? Tvdss { get; set; }

    public bool Enabled { get; set; }

    public int AzimuthType { get; set; }

    public int ImportSource { get; set; }

    public double? CourseLength { get; set; }

    public double? SigmaN { get; set; }

    public double? SigmaE { get; set; }

    public double? SigmaV { get; set; }

    public double? SigmaL { get; set; }

    public double? SigmaH { get; set; }

    public double? SigmaA { get; set; }

    public double? BiasN { get; set; }

    public double? BiasE { get; set; }

    public double? BiasV { get; set; }

    public double? BiasH { get; set; }

    public double? BiasL { get; set; }

    public double? BiasA { get; set; }

    public double? CorrHl { get; set; }

    public double? CorrHa { get; set; }

    public double? CorrLa { get; set; }

    public double? HmajSa { get; set; }

    public double? HminSa { get; set; }

    public double? RotAng { get; set; }

    public double? SemiAx1 { get; set; }

    public double? SemiAx2 { get; set; }

    public double? SemiAx3 { get; set; }

    public double? CovNn { get; set; }

    public double? CovNe { get; set; }

    public double? CovNv { get; set; }

    public double? CovEe { get; set; }

    public double? CovEv { get; set; }

    public double? CovVv { get; set; }

    public string? ToolCode { get; set; }

    public virtual Run Run { get; set; } = null!;
}
