using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class CustomerReportDatum
{
    public Guid Id { get; set; }

    public Guid WellId { get; set; }

    public byte[] ReportData { get; set; } = null!;
}
