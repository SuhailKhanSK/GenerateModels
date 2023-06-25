using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Template
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? TemplateContent { get; set; }

    public string? LastEditedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public DateTime CreatedTime { get; set; }

    public bool Deleted { get; set; }

    public int TemplateType { get; set; }
}
