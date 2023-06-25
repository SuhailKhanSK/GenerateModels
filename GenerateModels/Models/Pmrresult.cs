using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Pmrresult
{
    public Guid Id { get; set; }

    public Guid RangingDeterminationId { get; set; }

    public bool Deleted { get; set; }

    public int PmrCalculationType { get; set; }

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

    public double Md { get; set; }

    public double Range { get; set; }

    public double Az2Tg { get; set; }

    public double Hs2Tg { get; set; }

    public double Nshift { get; set; }

    public double Eshift { get; set; }

    public double Mwdmd { get; set; }

    public double Mwdinc { get; set; }

    public double MwdazCorr { get; set; }

    public virtual RangingDetermination RangingDetermination { get; set; } = null!;
}
