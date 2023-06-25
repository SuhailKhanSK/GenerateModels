using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Waypoint
{
    public Guid Id { get; set; }

    public Guid WellId { get; set; }

    public string? Name { get; set; }

    public double StartDepth { get; set; }

    public double EndDepth { get; set; }

    public double Elevation { get; set; }

    public int Type { get; set; }

    public double MeasuredDepth { get; set; }

    public double VerticalDepth { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public double Gravity { get; set; }

    public DateTime CalculatedDate { get; set; }

    public string? MagneticModel { get; set; }

    public double Bggmdeclination { get; set; }

    public double Bggmdip { get; set; }

    public double Bggmbtotal { get; set; }

    public double Ifrdeclination { get; set; }

    public double Ifrdip { get; set; }

    public double Ifrbtotal { get; set; }

    public double CadecOffset { get; set; }

    public double CadipOffset { get; set; }

    public double CabtOffset { get; set; }

    public double RefDeclination { get; set; }

    public double RefDip { get; set; }

    public double RefBtotal { get; set; }

    public string? Source { get; set; }

    public double GridConvergence { get; set; }

    public double BggmtotalCorrection { get; set; }

    public double IfrtotalCorrection { get; set; }

    public string? LastEditedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public DateTime CreatedTime { get; set; }

    public bool Deleted { get; set; }

    public string? HyperCube { get; set; }

    public int WaypointMode { get; set; }

    public bool IsForceMagDate { get; set; }

    public int Ifr1waypointMode { get; set; }

    public virtual Well Well { get; set; } = null!;
}
