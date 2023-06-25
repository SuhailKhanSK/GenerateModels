using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class CustomerImage
{
    public Guid Id { get; set; }

    public byte[] Data { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string ContentType { get; set; } = null!;

    public Guid WellId { get; set; }
}
