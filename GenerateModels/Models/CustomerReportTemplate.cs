using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class CustomerReportTemplate
{
    public Guid Id { get; set; }

    public string TemplateName { get; set; } = null!;

    public string TemplateType { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsEnabled { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedTime { get; set; }

    public string LastEditedBy { get; set; } = null!;

    public DateTime LastEditedTime { get; set; }
}
