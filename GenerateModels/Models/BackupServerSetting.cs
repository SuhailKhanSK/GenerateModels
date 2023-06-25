using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class BackupServerSetting
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int? Port { get; set; }

    public string? BaseResource { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? BgsUserName { get; set; }

    public string BgsPassword { get; set; } = null!;

    public string? BgsObservatoryUrl { get; set; }

    public string? ProxyUrl { get; set; }

    public string? SignalRurl { get; set; }

    public bool? IsProductionServer { get; set; }

    public string LoginUrl { get; set; } = null!;

    public string? LoggedInUrl { get; set; }

    public string? LogoutUrl { get; set; }

    public string? HostUrl { get; set; }

    public string? BgsBaseResource { get; set; }
}
