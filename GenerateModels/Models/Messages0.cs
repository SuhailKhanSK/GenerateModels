using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Messages0
{
    public long PayloadId { get; set; }

    public byte[] Payload { get; set; } = null!;

    public DateTime InsertedOn { get; set; }
}
