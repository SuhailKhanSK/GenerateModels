using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class OdisseusToolCodeDatum
{
    public Guid Id { get; set; }

    public byte[] Data { get; set; } = null!;
}
