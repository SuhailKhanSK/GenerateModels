using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class CustomerReportTemplateDatum
{
    public Guid Id { get; set; }

    public byte[] Data { get; set; } = null!;
}
