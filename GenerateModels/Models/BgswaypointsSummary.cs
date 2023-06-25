using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class BgswaypointsSummary
{
    public Guid Id { get; set; }

    public string? Field { get; set; }

    public string? PadRigInstallation { get; set; }

    public string? Well { get; set; }

    public string? Depths { get; set; }

    public string? TvdReferenceTo { get; set; }

    public string? ReferenceToMsl { get; set; }

    public string? Datum { get; set; }

    public string? Position { get; set; }

    public string? Date { get; set; }

    public string? MagneticFieldModel { get; set; }

    public string? FileName { get; set; }

    public double RefLatitude { get; set; }

    public double RefLongitude { get; set; }

    public virtual ICollection<Bgswaypoint> Bgswaypoints { get; set; } = new List<Bgswaypoint>();
}
