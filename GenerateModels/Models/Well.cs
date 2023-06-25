using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Well
{
    public Guid Id { get; set; }

    public string? InsiteWellId { get; set; }

    public string? OriginalInsiteWellId { get; set; }

    public string? Name { get; set; }

    public double TimeOffsetInterval { get; set; }

    public DateTime CalculatedTimeOffset { get; set; }

    public DateTime ResetTime { get; set; }

    public string? Rig { get; set; }

    public string? JobNumber { get; set; }

    public string? Region { get; set; }

    public string? Country { get; set; }

    public string? District { get; set; }

    public string? IpAddress { get; set; }

    public string? TimeZone { get; set; }

    public string? Customer { get; set; }

    public string? ProjectionDescription { get; set; }

    public int UnitSystem { get; set; }

    public int CartesianCordsUnitOption { get; set; }

    public int Status { get; set; }

    public int WellType { get; set; }

    public string? ProjectionReference { get; set; }

    public string? ProjectionGridSystem { get; set; }

    public string? ProjectionGroup { get; set; }

    public double ProjectionCentralMeridian { get; set; }

    public string? ProjectionMethod { get; set; }

    public string? MagneticModel { get; set; }

    public DateTime? MagneticCalcDate { get; set; }

    public string? MagDataSource { get; set; }

    public double Btotal { get; set; }

    public double Dip { get; set; }

    public double Declination { get; set; }

    public double GridConvergence { get; set; }

    public int NorthReference { get; set; }

    public string? Uom { get; set; }

    public double Elevation { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public double Northing { get; set; }

    public double Easting { get; set; }

    public double MeasuredDepth { get; set; }

    public string? Inclination { get; set; }

    public string? Azimuth { get; set; }

    public double Tvd { get; set; }

    public double Nsdeparture { get; set; }

    public double Ewdeparture { get; set; }

    public bool Locked { get; set; }

    public string? LockedBy { get; set; }

    public string? CoordinateSystem { get; set; }

    public string? FieldName { get; set; }

    public string? Apinumber { get; set; }

    public string? Company { get; set; }

    public bool Deleted { get; set; }

    public string? LastEditedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public DateTime CreatedTime { get; set; }

    public bool IsEnableStaticQc { get; set; }

    public double GtQcLimit { get; set; }

    public double BtQcLimit { get; set; }

    public double DipQcLimit { get; set; }

    public double BtDipQcLimit { get; set; }

    public double LowAzimuthQcLimit { get; set; }

    public double HighAzimuthQcLimit { get; set; }

    public int Roc { get; set; }

    public Guid ImportTemplateId { get; set; }

    public Guid ExportTemplateId { get; set; }

    public int Asamode { get; set; }

    public int AsasessionCount { get; set; }

    public int AsapendingSessionCount { get; set; }

    public int AsastatusEnum { get; set; }

    public string? Comments { get; set; }

    public int RigType { get; set; }

    public int Toolface { get; set; }

    public double SigmaValue { get; set; }

    public double Gtotal { get; set; }

    public bool IsForceUpdateHypercubeBgs { get; set; }

    public bool? AutoCalcPosition { get; set; }

    public bool Archived { get; set; }

    public string? ImportAdiserver { get; set; }

    public bool OverrideGeodeticScaleFactor { get; set; }

    public double? GeodeticScaleFactorValue { get; set; }

    public int GeodeticScaleFactorEnum { get; set; }

    public double? WgsLatitude { get; set; }

    public double? WgsLongitude { get; set; }

    public virtual ICollection<OdisseusToolCodeSection> OdisseusToolCodeSections { get; set; } = new List<OdisseusToolCodeSection>();

    public virtual ICollection<RangingDetermination> RangingDeterminations { get; set; } = new List<RangingDetermination>();

    public virtual ICollection<Run> Runs { get; set; } = new List<Run>();

    public virtual ICollection<Waypoint> Waypoints { get; set; } = new List<Waypoint>();
}
