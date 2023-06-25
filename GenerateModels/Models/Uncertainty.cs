using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Uncertainty
{
    public Guid Id { get; set; }

    public Guid CorrectedSurveyId { get; set; }

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

    public virtual CorrectedSurvey CorrectedSurvey { get; set; } = null!;
}
