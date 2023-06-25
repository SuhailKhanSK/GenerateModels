using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class CorrectedSurvey
{
    public Guid Id { get; set; }

    public Guid RawSurveyId { get; set; }

    public DateTime CalculationDateTime { get; set; }

    public string? AzimuthSolution { get; set; }

    public DateTime DateTime { get; set; }

    public long? RigTimeOffset { get; set; }

    public bool ManualTimeOffsetFlag { get; set; }

    public double Depth { get; set; }

    public bool Enabled { get; set; }

    public int PumpStatus { get; set; }

    public double? Gx { get; set; }

    public double? Gy { get; set; }

    public double? Gz { get; set; }

    public double? Bx { get; set; }

    public double? By { get; set; }

    public double? Bz { get; set; }

    public double? Mwdinclination { get; set; }

    public double? MwdshortCollar { get; set; }

    public double? MwdlongCollar { get; set; }

    public int AzimuthType { get; set; }

    public double? SagInclination { get; set; }

    public double? GravityToolFace { get; set; }

    public double? GxyzInclination { get; set; }

    public double? GxyInclination { get; set; }

    public double? GzInclination { get; set; }

    public double? ReferenceInclination { get; set; }

    public double? Gtotal { get; set; }

    public double? Goxy { get; set; }

    public double? RigInclination { get; set; }

    public double? RigAzimuthSc { get; set; }

    public double? RigAzimuthLc { get; set; }

    public double? BtMeasured { get; set; }

    public double? DipMeasured { get; set; }

    public double? BvMeasured { get; set; }

    public double? BhMeasured { get; set; }

    public double? SolAzm { get; set; }

    public double? SolAzmSc { get; set; }

    public double? SolAzmLc { get; set; }

    public double? SolDec { get; set; }

    public double? SolGridConv { get; set; }

    public double? SolInc { get; set; }

    public double? SolBz { get; set; }

    public double? SolGt { get; set; }

    public double? SolBt { get; set; }

    public double? SolDip { get; set; }

    public double? SolBtDip { get; set; }

    public double? NomGt { get; set; }

    public double? NomBt { get; set; }

    public double? NomDip { get; set; }

    public double? NomBtDip { get; set; }

    public double? ObservatoryDipRaw { get; set; }

    public double? ObservatoryBtraw { get; set; }

    public double? ObservatoryDecRaw { get; set; }

    public long? ObservatoryTimeOffset { get; set; }

    public DateTime? ObservatoryDateTimeRaw { get; set; }

    public string? AppliedIcarusSolution { get; set; }

    public string? AppliedCazandraSolution { get; set; }

    public string? AppliedService { get; set; }

    public int SurveyStatus { get; set; }

    public int SurveyType { get; set; }

    public bool Deleted { get; set; }

    public bool Expired { get; set; }

    public string? ErrorMessage { get; set; }

    public string? LastEditedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public DateTime CreatedTime { get; set; }

    public double? NomDeclination { get; set; }

    public double? NomGrid { get; set; }

    public int IcaUsed { get; set; }

    public int CazUsed { get; set; }

    public double? BtLimit { get; set; }

    public double? BtRssDynamicLimit { get; set; }

    public double? DipLimit { get; set; }

    public double? DipRssDynamicLimit { get; set; }

    public double? BtDipLimit { get; set; }

    public double? BtDipRssDynamicLimit { get; set; }

    public double? AzRssDynamicLimit { get; set; }

    public string? Comment { get; set; }

    public int Asaresult { get; set; }

    public double? Sisa { get; set; }

    public string? TypeEditedBy { get; set; }

    public int AsastatusEnum { get; set; }

    public int Asamode { get; set; }

    public double? IcadGx { get; set; }

    public double? IcadGy { get; set; }

    public double? IcadGz { get; set; }

    public double? IcaSfgx { get; set; }

    public double? IcaSfgy { get; set; }

    public double? CazdBx { get; set; }

    public double? CazdBy { get; set; }

    public double? CazdBz { get; set; }

    public double? CazSfbx { get; set; }

    public double? CazSfby { get; set; }

    public double? CourseLength { get; set; }

    public double? LcbtQcdelta { get; set; }

    public double? ScbtQcdelta { get; set; }

    public double? CazBtQcdelta { get; set; }

    public double? LcdipQcdelta { get; set; }

    public double? ScdipQcdelta { get; set; }

    public double? CazDipQcdelta { get; set; }

    public int? NorthReference { get; set; }

    public double? NorthSouth { get; set; }

    public double? EastWest { get; set; }

    public double? Easting { get; set; }

    public double? Northing { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public double? Tvd { get; set; }

    public double? Tvdss { get; set; }

    public double? SolBv { get; set; }

    public double? SolBh { get; set; }

    public double? NomBv { get; set; }

    public double? NomBh { get; set; }

    public double? SoldBx { get; set; }

    public double? SoldBy { get; set; }

    public double? SoldBz { get; set; }

    public double? Dclatitude { get; set; }

    public double? Dclongitude { get; set; }

    public double? Dctvdss { get; set; }

    public DateTime? ReceiveTime { get; set; }

    public DateTime? ProcessedTime { get; set; }

    public DateTime? SetDefinitiveTime { get; set; }

    public virtual ICollection<BgsDataPoint> BgsDataPoints { get; set; } = new List<BgsDataPoint>();

    public virtual ICollection<CorrectedSurveyValue> Values { get; set; } = new List<CorrectedSurveyValue>();

    public virtual RawSurvey RawSurvey { get; set; } = null!;

    public virtual ICollection<Uncertainty> Uncertainties { get; set; } = new List<Uncertainty>();
}
