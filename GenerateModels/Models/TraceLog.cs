using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class TraceLog
{
    public Guid Id { get; set; }

    public string? Message { get; set; }

    public DateTime Time { get; set; }
}
