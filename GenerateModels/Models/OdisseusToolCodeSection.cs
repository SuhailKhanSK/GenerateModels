using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class OdisseusToolCodeSection
{
    public Guid Id { get; set; }

    public Guid WellId { get; set; }

    public string? Customer { get; set; }

    public double StartDepth { get; set; }

    public double EndDepth { get; set; }

    public string? ToolCodeName { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public string LastEditedBy { get; set; } = null!;

    public DateTime LastEditedTime { get; set; }

    public Guid OdisseusToolCodeParamsId { get; set; }

    public virtual Well Well { get; set; } = null!;
}
