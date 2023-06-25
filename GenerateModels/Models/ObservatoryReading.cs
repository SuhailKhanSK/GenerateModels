using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class ObservatoryReading
{
    public Guid Id { get; set; }

    public Guid ObservatoryStationId { get; set; }

    public DateTime DateTime { get; set; }

    public double Declination { get; set; }

    public double Dip { get; set; }

    public double Btotal { get; set; }

    public string? BgsWebSiteName { get; set; }

    public virtual ObservatoryStation ObservatoryStation { get; set; } = null!;
}
