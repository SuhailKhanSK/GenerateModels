using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Plansurvey
{
    public Guid Id { get; set; }

    public Guid SolutionId { get; set; }

    public DateTime DateTime { get; set; }

    public double Depth { get; set; }

    public double? Mwdinclination { get; set; }

    public double? MwdshortCollar { get; set; }

    public DateTime? CreatedTime { get; set; }

    public bool? Deleted { get; set; }

    public double? NomBt { get; set; }

    public double? NomDeclination { get; set; }

    public double? NomGrid { get; set; }

    public double? NomDip { get; set; }

    public virtual Solution Solution { get; set; } = null!;
}
