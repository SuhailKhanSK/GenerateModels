using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class SpatrialLog
{
    public Guid Id { get; set; }

    public Guid RangingDeterminationId { get; set; }

    public bool Deleted { get; set; }

    public DateTime CalculationDateTime { get; set; }

    public double MdQ { get; set; }

    public double Rq { get; set; }

    public double Q { get; set; }

    public double Hs2Q { get; set; }

    public double Inc { get; set; }

    public double Az { get; set; }

    public double Beg { get; set; }

    public double Beh { get; set; }

    public double BgError { get; set; }

    public double BhError { get; set; }

    public virtual RangingDetermination RangingDetermination { get; set; } = null!;
}
