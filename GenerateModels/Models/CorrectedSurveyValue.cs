using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class CorrectedSurveyValue
{
    public Guid Id { get; set; }

    public Guid CorrectedSurveyId { get; set; }

    public double? Gx { get; set; }

    public double? Gy { get; set; }

    public double? Gz { get; set; }

    public double? Bx { get; set; }

    public double? By { get; set; }

    public double? Bz { get; set; }

    public double Gtotal { get; set; }

    public double GxyzInclination { get; set; }

    public double Goxy { get; set; }

    public double Boxy { get; set; }

    public double Btotal { get; set; }

    public double BtotalDip { get; set; }

    public double BtotalCalc { get; set; }

    public double BtotalBzCalc { get; set; }

    public double BtotalDipBzCalc { get; set; }

    public double BtotalDipBzMeasured { get; set; }

    public double Bv { get; set; }

    public double BvBzCalc { get; set; }

    public double BvCalc { get; set; }

    public double Bh { get; set; }

    public double BhCalc { get; set; }

    public double BhBzCalc { get; set; }

    public double BzCalc { get; set; }

    public double Dip { get; set; }

    public double DipCalc { get; set; }

    public double DipBzCalc { get; set; }

    public double Azimuth { get; set; }

    public double LongCollarAzimuth { get; set; }

    public double ShortCollarAzimuth { get; set; }

    public double Nsdeparture { get; set; }

    public double Ewdeparture { get; set; }

    public double Tvd { get; set; }

    public double HighSide { get; set; }

    public double Declination { get; set; }

    public double Inclination { get; set; }

    public double GridConvergence { get; set; }

    public int CalculationType { get; set; }

    public bool Deleted { get; set; }

    public bool Expired { get; set; }

    public virtual CorrectedSurvey CorrectedSurvey { get; set; } = null!;
}
