using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class RangingDetermination
{
    public Guid Id { get; set; }

    public Guid WellId { get; set; }

    public int SurveyType { get; set; }

    public string? Name { get; set; }

    public bool Deleted { get; set; }

    public bool RunSpa { get; set; }

    public bool RunDpa { get; set; }

    public bool RunHs2tg { get; set; }

    public double? MaxMdQ { get; set; }

    public double? MinMdQ { get; set; }

    public double? MinRq { get; set; }

    public double? MaxRq { get; set; }

    public double? MaxQ { get; set; }

    public double? MinQ { get; set; }

    public double? MinBeg { get; set; }

    public double? MaxBeg { get; set; }

    public double? MinBeh { get; set; }

    public double? MaxBeh { get; set; }

    public double? MinHs2Q { get; set; }

    public double? MaxHs2Q { get; set; }

    public double? MinAz { get; set; }

    public double? MaxAz { get; set; }

    public double? MinInc { get; set; }

    public double? MaxInc { get; set; }

    public double? MinStep { get; set; }

    public double? MaxStep { get; set; }

    public double Hs2Tg { get; set; }

    public double Hs2tgInclination { get; set; }

    public double Hs2tgAzimuth { get; set; }

    public double Hs2tgOtherPolarity { get; set; }

    public double Hs2tgCorCoeff { get; set; }

    public int Hs2tgSelectedSurveys { get; set; }

    public string? LastEditedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public DateTime CreatedTime { get; set; }

    public virtual ICollection<DpatrialLog> DpatrialLogs { get; set; } = new List<DpatrialLog>();

    public virtual ICollection<Hs2TgTrialLog> Hs2TgTrialLogs { get; set; } = new List<Hs2TgTrialLog>();

    public virtual ICollection<Pmrresult> Pmrresults { get; set; } = new List<Pmrresult>();

    public virtual ICollection<PmrsurveyBase> PmrsurveyBaseRangingDeterminationId1Navigations { get; set; } = new List<PmrsurveyBase>();

    public virtual ICollection<PmrsurveyBase> PmrsurveyBaseRangingDeterminationId2Navigations { get; set; } = new List<PmrsurveyBase>();

    public virtual ICollection<PmrsurveyBase> PmrsurveyBaseRangingDeterminations { get; set; } = new List<PmrsurveyBase>();

    public virtual ICollection<SpatrialLog> SpatrialLogs { get; set; } = new List<SpatrialLog>();

    public virtual Well Well { get; set; } = null!;
}
