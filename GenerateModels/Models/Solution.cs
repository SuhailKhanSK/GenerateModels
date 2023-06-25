using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class Solution
{
    public Guid Id { get; set; }

    public Guid RunId { get; set; }

    public Guid? ObservatoryStationId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedTime { get; set; }

    public string? LastEditedBy { get; set; }

    public DateTime LastEditedTime { get; set; }

    public bool Deleted { get; set; }

    public double StartDepth { get; set; }

    public double EndDepth { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime EndTime { get; set; }

    public int ToolTypeOptions { get; set; }

    public int Service { get; set; }

    public int SolutionType { get; set; }

    public int InclinationSolution { get; set; }

    public int NorthReference { get; set; }

    public int PumpStatusFilter { get; set; }

    public int RigMagValueType { get; set; }

    public string? SelectedWayPoint { get; set; }

    public double MfmMagneticFieldStrength { get; set; }

    public double MfmMagneticDipAngle { get; set; }

    public double MfmDeclination { get; set; }

    public double MfmGridConvergence { get; set; }

    public double MfmTotalCorrection { get; set; }

    public double IfrMagneticFieldStrength { get; set; }

    public double IfrMagneticDipAngle { get; set; }

    public double IfrDeclination { get; set; }

    public double IfrGridConvergence { get; set; }

    public double IfrTotalCorrection { get; set; }

    public int ObsDataType { get; set; }

    public string? MagneticModel { get; set; }

    public DateTime CalculationDate { get; set; }

    public double ObsSiteDeclination { get; set; }

    public double ObsSiteDip { get; set; }

    public double ObsSiteBtotal { get; set; }

    public long? RigTimeOffset { get; set; }

    public bool ForceManualTimeOffset { get; set; }

    public bool RunCazandra { get; set; }

    public int CazandraSolution { get; set; }

    public int CazandraMagneticValsType { get; set; }

    public int ConsecutiveStation { get; set; }

    public int RawdataQuadrant { get; set; }

    public int Tfcquadrant { get; set; }

    public int TransXyquadrant { get; set; }

    public int Sfequadrant { get; set; }

    public int Diyquadrant { get; set; }

    public int TriacSelectionMode { get; set; }

    public bool ApplyBgmisalignment { get; set; }

    public bool ApplyBzOffset { get; set; }

    public bool Ifrdata { get; set; }

    public bool ApplyIcarusCalculations { get; set; }

    public bool CalculateAndApplyBzMisalignment { get; set; }

    public double Bgmisalignment { get; set; }

    public double BzOffset { get; set; }

    public double Dbx { get; set; }

    public double Dby { get; set; }

    public double Dbz { get; set; }

    public double Sfbx { get; set; }

    public double Sfby { get; set; }

    public double OffsetAngle { get; set; }

    public double Direction { get; set; }

    public string? CazandraIngoredSurveys { get; set; }

    public string? CazandraExcludedSurveys { get; set; }

    public bool RunIcarus { get; set; }

    public int IcarusSolution { get; set; }

    public string? IcarusVersion { get; set; }

    public double IcarusStationsCount { get; set; }

    public bool? IcarusToolType { get; set; }

    public double IcarusCalibrationLatitude { get; set; }

    public double IcarusWellLatitude { get; set; }

    public double IcarusDgx { get; set; }

    public double IcarusDgy { get; set; }

    public double IcarusDgz { get; set; }

    public double IcarusSfgx { get; set; }

    public double IcarusSfgy { get; set; }

    public int IcarusLatitudeType { get; set; }

    public double TheoreticGravity { get; set; }

    public string? IcarusIngoredSurveys { get; set; }

    public string? IcarusExcludedSurveys { get; set; }

    public bool RunDynamicQc { get; set; }

    public int? Qctype { get; set; }

    public bool? IsAdvancedMode { get; set; }

    public int? MagneticReference { get; set; }

    public int? AziType { get; set; }

    public int? Mode { get; set; }

    public int? Msa { get; set; }

    public string? IpmtoolCode { get; set; }

    public double? Dgxyz { get; set; }

    public double? Dbxyz { get; set; }

    public double? DbzMod { get; set; }

    public double? Ddipe { get; set; }

    public double? Dbe { get; set; }

    public double? Dec { get; set; }

    public double? Dbh { get; set; }

    public double? Dbnoise { get; set; }

    public double? DdipNoise { get; set; }

    public double? Sxy { get; set; }

    public double? Sigma { get; set; }

    public bool UseIcarusGz { get; set; }

    public bool UseSagInc { get; set; }

    public virtual ICollection<MaxSurveyPreConditionRule> MaxSurveyPreConditionRules { get; set; } = new List<MaxSurveyPreConditionRule>();

    public virtual ICollection<MaxSurveyRule> MaxSurveyRules { get; set; } = new List<MaxSurveyRule>();

    public virtual ObservatoryStation? ObservatoryStation { get; set; }

    public virtual ICollection<Plansurvey> Plansurveys { get; set; } = new List<Plansurvey>();

    public virtual Run Run { get; set; } = null!;
}
