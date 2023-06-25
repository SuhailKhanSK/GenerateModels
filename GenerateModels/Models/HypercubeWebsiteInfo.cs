using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class HypercubeWebsiteInfo
{
    public string? HypercubeSiteName { get; set; }

    public string? Websiteurl { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? SiteStatus { get; set; }

    public Guid Id { get; set; }

    public DateTime? MinDate { get; set; }

    public DateTime? MaxDate { get; set; }

    public double? MinDepth { get; set; }

    public double? MaxDepth { get; set; }

    public double? MinLatitude { get; set; }

    public double? MaxLatitude { get; set; }

    public double? MinLongitude { get; set; }

    public double? MaxLongitude { get; set; }
}
