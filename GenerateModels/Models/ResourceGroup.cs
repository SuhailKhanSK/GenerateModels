using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class ResourceGroup
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public Guid WellId { get; set; }

    public Guid AppUserId { get; set; }

    public byte Permission { get; set; }

    public string? LastEditedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public DateTime CreatedTime { get; set; }
}
