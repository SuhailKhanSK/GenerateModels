using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Bgswaypoint
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public double StartDepth { get; set; }

    public double EndDepth { get; set; }

    public double Elevation { get; set; }

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

    public Guid? SummaryId { get; set; }

    public virtual BgswaypointsSummary? Summary { get; set; }
}
