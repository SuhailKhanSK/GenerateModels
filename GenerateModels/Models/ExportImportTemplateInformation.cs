using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class ExportImportTemplateInformation
{
    public Guid Id { get; set; }

    public string? TemplateName { get; set; }

    public string? Description { get; set; }

    public string? ImportFileName { get; set; }

    public bool IsDefault { get; set; }

    public int? TemplateType { get; set; }

    public byte[]? Data { get; set; }

    public string? LastEditedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? LastEditedTime { get; set; }

    public DateTime? CreatedTime { get; set; }

    public string? Roc { get; set; }
}
