using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class AuditLog
{
    public Guid Id { get; set; }

    public Guid EntityId { get; set; }

    public string EntityType { get; set; } = null!;

    public string? Data { get; set; }

    public string? LastEditedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public int AuditType { get; set; }

    public string? Comments { get; set; }
}
