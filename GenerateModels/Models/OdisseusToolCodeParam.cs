using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class OdisseusToolCodeParam
{
    public Guid Id { get; set; }

    public Guid FileId { get; set; }

    public string ToolCodeName { get; set; } = null!;

    public double? Dsf { get; set; }

    public double? Dst { get; set; }

    public double? Dstb { get; set; }

    public double? Sag { get; set; }

    public double? Mxy1 { get; set; }

    public double? Mxy2 { get; set; }

    public double? Ab { get; set; }

    public double? As { get; set; }

    public double? Mb { get; set; }

    public double? Ms { get; set; }

    public double? Amic { get; set; }

    public double? Amid { get; set; }

    public double? Amil { get; set; }

    public double? Amib { get; set; }

    public double? Az { get; set; }

    public double? Azrandom { get; set; }

    public double? Dbh { get; set; }

    public double? Dbhrandom { get; set; }

    public double? Mfi { get; set; }

    public double? Mfirandom { get; set; }

    public double? Mdi { get; set; }

    public double? Mdirandom { get; set; }

    public double? Mm { get; set; }

    public double? DrefrFix { get; set; }

    public double? DrefrFloat { get; set; }

    public double? DrefFix { get; set; }

    public double? DrefFloat { get; set; }

    public int LongScc { get; set; }

    public int DepthStation { get; set; }
}
