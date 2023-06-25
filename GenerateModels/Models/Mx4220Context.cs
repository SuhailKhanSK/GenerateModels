using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GenerateModels.Models;

public partial class Mx4220Context : DbContext
{
    public Mx4220Context()
    {
        ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
    }

    public Mx4220Context(DbContextOptions<Mx4220Context> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminUser> AdminUsers { get; set; }

    public virtual DbSet<AppUser> AppUsers { get; set; }

    public virtual DbSet<AsaGlobalPreConditionRule> AsaGlobalPreConditionRules { get; set; }

    public virtual DbSet<AsaGlobalRule> AsaGlobalRules { get; set; }

    public virtual DbSet<AuditLog> AuditLogs { get; set; }

    public virtual DbSet<BackupServerSetting> BackupServerSettings { get; set; }

    public virtual DbSet<BgsDataPoint> BgsDataPoints { get; set; }

    public virtual DbSet<BgsWebsiteInfo> BgsWebsiteInfos { get; set; }

    public virtual DbSet<Bgswaypoint> Bgswaypoints { get; set; }

    public virtual DbSet<BgswaypointsSummary> BgswaypointsSummaries { get; set; }

    public virtual DbSet<CorrectedSurvey> CorrectedSurveys { get; set; }

    public virtual DbSet<CorrectedSurveyValue> CorrectedSurveyValues { get; set; }

    public virtual DbSet<CustomerImage> CustomerImages { get; set; }

    public virtual DbSet<CustomerReport> CustomerReports { get; set; }

    public virtual DbSet<CustomerReportDatum> CustomerReportData { get; set; }

    public virtual DbSet<CustomerReportTemplate> CustomerReportTemplates { get; set; }

    public virtual DbSet<CustomerReportTemplateDatum> CustomerReportTemplateData { get; set; }

    public virtual DbSet<DpatrialLog> DpatrialLogs { get; set; }

    public virtual DbSet<ExportImportTemplateInformation> ExportImportTemplateInformations { get; set; }

    public virtual DbSet<Hs2TgTrialLog> Hs2TgTrialLogs { get; set; }

    public virtual DbSet<HypercubeWebsiteInfo> HypercubeWebsiteInfos { get; set; }

    public virtual DbSet<MaxSurveyActionResult> MaxSurveyActionResults { get; set; }

    public virtual DbSet<MaxSurveyPreConditionRule> MaxSurveyPreConditionRules { get; set; }

    public virtual DbSet<MaxSurveyRule> MaxSurveyRules { get; set; }

    public virtual DbSet<MaxSurveyRuleResponse> MaxSurveyRuleResponses { get; set; }

    public virtual DbSet<MaxSurveyRuleSetResponse> MaxSurveyRuleSetResponses { get; set; }

    public virtual DbSet<Messages0> Messages0s { get; set; }

    public virtual DbSet<Messages0Id> Messages0Ids { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<ObservatoryReading> ObservatoryReadings { get; set; }

    public virtual DbSet<ObservatoryStation> ObservatoryStations { get; set; }

    public virtual DbSet<OdisseusToolCode> OdisseusToolCodes { get; set; }

    public virtual DbSet<OdisseusToolCodeDatum> OdisseusToolCodeData { get; set; }

    public virtual DbSet<OdisseusToolCodeParam> OdisseusToolCodeParams { get; set; }

    public virtual DbSet<OdisseusToolCodeSection> OdisseusToolCodeSections { get; set; }

    public virtual DbSet<Plansurvey> Plansurveys { get; set; }

    public virtual DbSet<Pmrresult> Pmrresults { get; set; }

    public virtual DbSet<PmrsurveyBase> PmrsurveyBases { get; set; }

    public virtual DbSet<RangingDetermination> RangingDeterminations { get; set; }

    public virtual DbSet<RawSurvey> RawSurveys { get; set; }

    public virtual DbSet<ResourceGroup> ResourceGroups { get; set; }

    public virtual DbSet<Run> Runs { get; set; }

    public virtual DbSet<Schema> Schemas { get; set; }

    public virtual DbSet<Shortsurvey> Shortsurveys { get; set; }

    public virtual DbSet<Solution> Solutions { get; set; }

    public virtual DbSet<SpatrialLog> SpatrialLogs { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<TraceLog> TraceLogs { get; set; }

    public virtual DbSet<Uncertainty> Uncertainties { get; set; }

    public virtual DbSet<WaitObservatoryCorrectedSurvey> WaitObservatoryCorrectedSurveys { get; set; }

    public virtual DbSet<Waypoint> Waypoints { get; set; }

    public virtual DbSet<Well> Wells { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=MX4220;User Id=sa;Password=HAL@VSCPassword123;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminUser>(entity =>
        {
            entity.ToTable("AdminUser", "Security");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.EmailId).HasMaxLength(100);
            entity.Property(e => e.LastEditedBy).HasMaxLength(100);
            entity.Property(e => e.NetworkId).HasMaxLength(10);
        });

        modelBuilder.Entity<AppUser>(entity =>
        {
            entity.ToTable("AppUser", "Security");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.FirstName).HasMaxLength(200);
            entity.Property(e => e.IsActive)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastEditedBy).HasMaxLength(100);
            entity.Property(e => e.LastLoginDate).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(200);
            entity.Property(e => e.NetworkId).HasMaxLength(50);
        });

        modelBuilder.Entity<AsaGlobalPreConditionRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ASAGlobalPreConditionRule");

            entity.ToTable("AsaGlobalPreConditionRule");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.IsEnabled)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastEditedBy).HasMaxLength(50);
            entity.Property(e => e.Lhs)
                .HasMaxLength(500)
                .HasColumnName("LHS");
            entity.Property(e => e.Rhs)
                .HasMaxLength(500)
                .HasColumnName("RHS");
            entity.Property(e => e.RuleName).HasMaxLength(80);
            entity.Property(e => e.UnitSystem).HasMaxLength(50);
            entity.Property(e => e.UnitTypeName).HasMaxLength(50);
            entity.Property(e => e.Units).HasMaxLength(50);
        });

        modelBuilder.Entity<AsaGlobalRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ASAGlobalRule");

            entity.ToTable("AsaGlobalRule");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.IsEnabled)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastEditedBy).HasMaxLength(50);
            entity.Property(e => e.Lhs)
                .HasMaxLength(500)
                .HasColumnName("LHS");
            entity.Property(e => e.Rhs)
                .HasMaxLength(500)
                .HasColumnName("RHS");
            entity.Property(e => e.RuleName).HasMaxLength(80);
            entity.Property(e => e.UnitSystem).HasMaxLength(50);
            entity.Property(e => e.UnitTypeName).HasMaxLength(50);
            entity.Property(e => e.Units).HasMaxLength(50);

            entity.HasOne(d => d.PreConditionRule).WithMany(p => p.AsaGlobalRules)
                .HasForeignKey(d => d.PreConditionRuleId)
                .HasConstraintName("FK_dbo.AsaGlobalRule_dbo.AsaGlobalPreConditionRule_PreConditionRuleId");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.ToTable("AuditLog");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.EntityType).HasMaxLength(150);
        });

        modelBuilder.Entity<BackupServerSetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ApiServerSettings");

            entity.ToTable("BackupServerSetting");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.BgsPassword).HasMaxLength(50);
            entity.Property(e => e.BgsUserName).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.SignalRurl).HasColumnName("SignalRUrl");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<BgsDataPoint>(entity =>
        {
            entity.ToTable("BgsDataPoint");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Tvdss).HasColumnName("TVDss");

            entity.HasOne(d => d.CorrectedSurvey).WithMany(p => p.BgsDataPoints)
                .HasForeignKey(d => d.CorrectedSurveyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BgsDataPoint_CorrectedSurvey");
        });

        modelBuilder.Entity<BgsWebsiteInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BgsWebsiteInfo");

            entity.ToTable("BgsWebsiteInfo");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.SiteStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('Standby')");
            entity.Property(e => e.Websitename)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Bgswaypoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BGSWaypoint");

            entity.ToTable("BGSWaypoint");

            entity.HasIndex(e => e.SummaryId, "IX_Summary_Id");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Bggmbtotal).HasColumnName("BGGMBTotal");
            entity.Property(e => e.Bggmdeclination).HasColumnName("BGGMDeclination");
            entity.Property(e => e.Bggmdip).HasColumnName("BGGMDip");
            entity.Property(e => e.CabtOffset).HasColumnName("CABtOffset");
            entity.Property(e => e.CadecOffset).HasColumnName("CADecOffset");
            entity.Property(e => e.CadipOffset).HasColumnName("CADipOffset");
            entity.Property(e => e.Ifrbtotal).HasColumnName("IFRBTotal");
            entity.Property(e => e.Ifrdeclination).HasColumnName("IFRDeclination");
            entity.Property(e => e.Ifrdip).HasColumnName("IFRDip");
            entity.Property(e => e.SummaryId).HasColumnName("Summary_Id");

            entity.HasOne(d => d.Summary).WithMany(p => p.Bgswaypoints)
                .HasForeignKey(d => d.SummaryId)
                .HasConstraintName("FK_dbo.BGSWaypoint_dbo.BGSWaypointsSummary_Summary_Id");
        });

        modelBuilder.Entity<BgswaypointsSummary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.BGSWaypointsSummary");

            entity.ToTable("BGSWaypointsSummary");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<CorrectedSurvey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CorrectedSurvey");

            entity.ToTable("CorrectedSurvey");

            entity.HasIndex(e => new { e.RawSurveyId, e.DateTime, e.Depth }, "IX_CorrectedSurvey_RawSurveyDateTimeDepth")
                .IsUnique()
                .HasFilter("([deleted]=(0))");

            entity.HasIndex(e => e.RawSurveyId, "IX_RawSurveyId").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Asamode).HasColumnName("ASAMode");
            entity.Property(e => e.Asaresult).HasColumnName("ASAResult");
            entity.Property(e => e.AsastatusEnum)
                .HasDefaultValueSql("((7))")
                .HasColumnName("ASAStatusEnum");
            entity.Property(e => e.CazBtQcdelta).HasColumnName("CazBtQCDelta");
            entity.Property(e => e.CazDipQcdelta).HasColumnName("CazDipQCDelta");
            entity.Property(e => e.CazSfbx)
                .HasDefaultValueSql("((0.0))")
                .HasColumnName("CazSFBx");
            entity.Property(e => e.CazSfby)
                .HasDefaultValueSql("((0.0))")
                .HasColumnName("CazSFBy");
            entity.Property(e => e.CazdBx).HasDefaultValueSql("((0.0))");
            entity.Property(e => e.CazdBy).HasDefaultValueSql("((0.0))");
            entity.Property(e => e.CazdBz).HasDefaultValueSql("((0.0))");
            entity.Property(e => e.Comment).HasMaxLength(50);
            entity.Property(e => e.CourseLength).HasDefaultValueSql("((0.0))");
            entity.Property(e => e.Dclatitude).HasColumnName("DCLatitude");
            entity.Property(e => e.Dclongitude).HasColumnName("DCLongitude");
            entity.Property(e => e.Dctvdss).HasColumnName("DCTVDss");
            entity.Property(e => e.ErrorMessage)
                .HasMaxLength(1200)
                .IsUnicode(false);
            entity.Property(e => e.Gtotal).HasColumnName("GTotal");
            entity.Property(e => e.IcaSfgx)
                .HasDefaultValueSql("((0.0))")
                .HasColumnName("IcaSFGx");
            entity.Property(e => e.IcaSfgy)
                .HasDefaultValueSql("((0.0))")
                .HasColumnName("IcaSFGy");
            entity.Property(e => e.IcadGx).HasDefaultValueSql("((0.0))");
            entity.Property(e => e.IcadGy).HasDefaultValueSql("((0.0))");
            entity.Property(e => e.IcadGz).HasDefaultValueSql("((0.0))");
            entity.Property(e => e.LcbtQcdelta).HasColumnName("LCBtQCDelta");
            entity.Property(e => e.LcdipQcdelta).HasColumnName("LCDipQCDelta");
            entity.Property(e => e.Mwdinclination).HasColumnName("MWDInclination");
            entity.Property(e => e.MwdlongCollar).HasColumnName("MWDLongCollar");
            entity.Property(e => e.MwdshortCollar).HasColumnName("MWDShortCollar");
            entity.Property(e => e.ObservatoryBtraw).HasColumnName("ObservatoryBTRaw");
            entity.Property(e => e.ProcessedTime).HasColumnType("datetime");
            entity.Property(e => e.ReceiveTime).HasColumnType("datetime");
            entity.Property(e => e.RigAzimuthLc).HasColumnName("RigAzimuthLC");
            entity.Property(e => e.RigAzimuthSc).HasColumnName("RigAzimuthSC");
            entity.Property(e => e.ScbtQcdelta).HasColumnName("SCBtQCDelta");
            entity.Property(e => e.ScdipQcdelta).HasColumnName("SCDipQCDelta");
            entity.Property(e => e.SetDefinitiveTime).HasColumnType("datetime");
            entity.Property(e => e.Sisa).HasColumnName("SISA");
            entity.Property(e => e.Tvd).HasColumnName("TVD");
            entity.Property(e => e.Tvdss).HasColumnName("TVDss");

            entity.HasOne(d => d.RawSurvey).WithOne(p => p.CorrectedSurvey)
                .HasForeignKey<CorrectedSurvey>(d => d.RawSurveyId)
                .HasConstraintName("FK_dbo.CorrectedSurvey_dbo.RawSurvey_RawSurveyId");
        });

        modelBuilder.Entity<CorrectedSurveyValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.CorrectedSurveyValues");

            entity.HasIndex(e => new { e.CorrectedSurveyId, e.CalculationType }, "IX_CorrectedSurveyId").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Btotal).HasColumnName("BTotal");
            entity.Property(e => e.BtotalBzCalc).HasColumnName("BTotalBzCalc");
            entity.Property(e => e.BtotalCalc).HasColumnName("BTotalCalc");
            entity.Property(e => e.BtotalDip).HasColumnName("BTotalDip");
            entity.Property(e => e.BtotalDipBzCalc).HasColumnName("BTotalDipBzCalc");
            entity.Property(e => e.BtotalDipBzMeasured).HasColumnName("BTotalDipBzMeasured");
            entity.Property(e => e.Ewdeparture).HasColumnName("EWDeparture");
            entity.Property(e => e.Gtotal).HasColumnName("GTotal");
            entity.Property(e => e.Nsdeparture).HasColumnName("NSDeparture");
            entity.Property(e => e.Tvd).HasColumnName("TVD");

            entity.HasOne(d => d.CorrectedSurvey).WithMany(p => p.Values)
                .HasForeignKey(d => d.CorrectedSurveyId)
                .HasConstraintName("FK_dbo.CorrectedSurveyValues_dbo.CorrectedSurvey_CorrectedSurveyId");
        });

        modelBuilder.Entity<CustomerImage>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ContentType).HasMaxLength(10);
            entity.Property(e => e.FileName).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerReport>(entity =>
        {
            entity.ToTable("CustomerReport");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.LastEditedBy).HasMaxLength(100);
            entity.Property(e => e.LastEditedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerReportDatum>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<CustomerReportTemplate>(entity =>
        {
            entity.ToTable("CustomerReportTemplate");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastEditedBy).HasMaxLength(100);
            entity.Property(e => e.LastEditedTime).HasColumnType("datetime");
            entity.Property(e => e.TemplateName).HasMaxLength(500);
            entity.Property(e => e.TemplateType).HasMaxLength(100);
        });

        modelBuilder.Entity<CustomerReportTemplateDatum>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<DpatrialLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.DPATrialLog");

            entity.ToTable("DPATrialLog");

            entity.HasIndex(e => e.RangingDeterminationId, "IX_RangingDeterminationId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Hs2tg).HasColumnName("HS2Tg");

            entity.HasOne(d => d.RangingDetermination).WithMany(p => p.DpatrialLogs)
                .HasForeignKey(d => d.RangingDeterminationId)
                .HasConstraintName("FK_dbo.DPATrialLog_dbo.RangingDetermination_RangingDeterminationId");
        });

        modelBuilder.Entity<ExportImportTemplateInformation>(entity =>
        {
            entity.ToTable("ExportImportTemplateInformation");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.LastEditedBy).HasMaxLength(100);
            entity.Property(e => e.Roc)
                .HasMaxLength(50)
                .HasColumnName("ROC");
        });

        modelBuilder.Entity<Hs2TgTrialLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Hs2TgTrialLog");

            entity.ToTable("Hs2TgTrialLog");

            entity.HasIndex(e => e.RangingDeterminationId, "IX_RangingDeterminationId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ModelBeg).HasColumnName("ModelBEg");
            entity.Property(e => e.ModelBeh).HasColumnName("ModelBEh");

            entity.HasOne(d => d.RangingDetermination).WithMany(p => p.Hs2TgTrialLogs)
                .HasForeignKey(d => d.RangingDeterminationId)
                .HasConstraintName("FK_dbo.Hs2TgTrialLog_dbo.RangingDetermination_RangingDeterminationId");
        });

        modelBuilder.Entity<HypercubeWebsiteInfo>(entity =>
        {
            entity.ToTable("HypercubeWebsiteInfo");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.HypercubeSiteName).HasMaxLength(50);
            entity.Property(e => e.MaxDate).HasColumnType("date");
            entity.Property(e => e.MinDate).HasColumnType("date");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.SiteStatus).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<MaxSurveyActionResult>(entity =>
        {
            entity.ToTable("MaxSurveyActionResult");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ActionName).HasMaxLength(50);
        });

        modelBuilder.Entity<MaxSurveyPreConditionRule>(entity =>
        {
            entity.ToTable("MaxSurveyPreConditionRule");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.IsEnabled)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastEditedBy).HasMaxLength(50);
            entity.Property(e => e.Lhs).HasColumnName("LHS");
            entity.Property(e => e.Rhs).HasColumnName("RHS");
            entity.Property(e => e.UnitSystem).HasMaxLength(50);
            entity.Property(e => e.UnitTypeName).HasMaxLength(50);
            entity.Property(e => e.Units).HasMaxLength(50);

            entity.HasOne(d => d.Solution).WithMany(p => p.MaxSurveyPreConditionRules)
                .HasForeignKey(d => d.SolutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaxSurveyPreConditionRule_MaxSurveyPreConditionRule");
        });

        modelBuilder.Entity<MaxSurveyRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_MaxSurveyRuleNEW");

            entity.ToTable("MaxSurveyRule");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(50);
            entity.Property(e => e.IsEnabled)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.LastEditedBy).HasMaxLength(50);
            entity.Property(e => e.Lhs).HasColumnName("LHS");
            entity.Property(e => e.Rhs).HasColumnName("RHS");
            entity.Property(e => e.UnitSystem).HasMaxLength(50);

            entity.HasOne(d => d.Solution).WithMany(p => p.MaxSurveyRules)
                .HasForeignKey(d => d.SolutionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MaxSurveyRuleNEW_MaxSurveyRuleNEW");
        });

        modelBuilder.Entity<MaxSurveyRuleResponse>(entity =>
        {
            entity.ToTable("MaxSurveyRuleResponse");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.PreConditionUnit).HasMaxLength(50);
            entity.Property(e => e.RuleName).HasMaxLength(50);
            entity.Property(e => e.Unit).HasMaxLength(50);
        });

        modelBuilder.Entity<MaxSurveyRuleSetResponse>(entity =>
        {
            entity.ToTable("MaxSurveyRuleSetResponse");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<Messages0>(entity =>
        {
            entity.HasKey(e => e.PayloadId).HasName("PK__Messages__A18B4A8FB3DFBF38");

            entity.ToTable("Messages_0", "SignalR");

            entity.Property(e => e.PayloadId).ValueGeneratedNever();
            entity.Property(e => e.InsertedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Messages0Id>(entity =>
        {
            entity.HasKey(e => e.PayloadId).HasName("PK__Messages__A18B4A8FA3269609");

            entity.ToTable("Messages_0_Id", "SignalR");

            entity.Property(e => e.PayloadId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<ObservatoryReading>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ObservatoryReading");

            entity.ToTable("ObservatoryReading");

            entity.HasIndex(e => e.ObservatoryStationId, "IX_ObservatoryStationId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.BgsWebSiteName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Btotal).HasColumnName("BTotal");

            entity.HasOne(d => d.ObservatoryStation).WithMany(p => p.ObservatoryReadings)
                .HasForeignKey(d => d.ObservatoryStationId)
                .HasConstraintName("FK_dbo.ObservatoryReading_dbo.ObservatoryStation_ObservatoryStationId");
        });

        modelBuilder.Entity<ObservatoryStation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.ObservatoryStation");

            entity.ToTable("ObservatoryStation");

            entity.HasIndex(e => e.Name, "ObservatoryStation_Name").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .HasDefaultValueSql("(' ')");
        });

        modelBuilder.Entity<OdisseusToolCode>(entity =>
        {
            entity.ToTable("OdisseusToolCode");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.FileName).HasMaxLength(500);
            entity.Property(e => e.LastEditedBy).HasMaxLength(100);
            entity.Property(e => e.LastEditedTime).HasColumnType("datetime");
        });

        modelBuilder.Entity<OdisseusToolCodeDatum>(entity =>
        {
            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<OdisseusToolCodeParam>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Ab).HasColumnName("AB");
            entity.Property(e => e.Amib).HasColumnName("AMIB");
            entity.Property(e => e.Amic).HasColumnName("AMIC");
            entity.Property(e => e.Amid).HasColumnName("AMID");
            entity.Property(e => e.Amil).HasColumnName("AMIL");
            entity.Property(e => e.As).HasColumnName("AS");
            entity.Property(e => e.Az).HasColumnName("AZ");
            entity.Property(e => e.Azrandom).HasColumnName("AZrandom");
            entity.Property(e => e.Dbh).HasColumnName("DBH");
            entity.Property(e => e.Dbhrandom).HasColumnName("DBHrandom");
            entity.Property(e => e.DepthStation).HasDefaultValueSql("((2))");
            entity.Property(e => e.DrefFix).HasColumnName("DREF_Fix");
            entity.Property(e => e.DrefFloat).HasColumnName("DREF_Float");
            entity.Property(e => e.DrefrFix).HasColumnName("DREFr_Fix");
            entity.Property(e => e.DrefrFloat).HasColumnName("DREFr_Float");
            entity.Property(e => e.Dsf).HasColumnName("DSF");
            entity.Property(e => e.Dst).HasColumnName("DST");
            entity.Property(e => e.Dstb).HasColumnName("DSTB");
            entity.Property(e => e.LongScc)
                .HasDefaultValueSql("((2))")
                .HasColumnName("LongSCC");
            entity.Property(e => e.Mb).HasColumnName("MB");
            entity.Property(e => e.Mdi).HasColumnName("MDI");
            entity.Property(e => e.Mdirandom).HasColumnName("MDIrandom");
            entity.Property(e => e.Mfi).HasColumnName("MFI");
            entity.Property(e => e.Mfirandom).HasColumnName("MFIrandom");
            entity.Property(e => e.Mm).HasColumnName("MM");
            entity.Property(e => e.Ms).HasColumnName("MS");
            entity.Property(e => e.Mxy1).HasColumnName("MXY1");
            entity.Property(e => e.Mxy2).HasColumnName("MXY2");
            entity.Property(e => e.Sag).HasColumnName("SAG");
            entity.Property(e => e.ToolCodeName).HasMaxLength(500);
        });

        modelBuilder.Entity<OdisseusToolCodeSection>(entity =>
        {
            entity.ToTable("OdisseusToolCodeSection");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedTime).HasColumnType("datetime");
            entity.Property(e => e.LastEditedTime).HasColumnType("datetime");

            entity.HasOne(d => d.Well).WithMany(p => p.OdisseusToolCodeSections)
                .HasForeignKey(d => d.WellId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OdisseusToolCodeSection_Well");
        });

        modelBuilder.Entity<Plansurvey>(entity =>
        {
            entity.ToTable("Plansurvey");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.CreatedTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Mwdinclination).HasColumnName("MWDInclination");
            entity.Property(e => e.MwdshortCollar).HasColumnName("MWDShortCollar");

            entity.HasOne(d => d.Solution).WithMany(p => p.Plansurveys)
                .HasForeignKey(d => d.SolutionId)
                .HasConstraintName("FK_Plansurvey_Solution");
        });

        modelBuilder.Entity<Pmrresult>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PMRResult");

            entity.ToTable("PMRResult");

            entity.HasIndex(e => e.RangingDeterminationId, "IX_RangingDeterminationId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Beg).HasColumnName("BEg");
            entity.Property(e => e.Beh).HasColumnName("BEh");
            entity.Property(e => e.MwdazCorr).HasColumnName("MWDazCorr");
            entity.Property(e => e.Mwdinc).HasColumnName("MWDInc");
            entity.Property(e => e.Mwdmd).HasColumnName("MWDmd");
            entity.Property(e => e.Rq).HasColumnName("RQ");

            entity.HasOne(d => d.RangingDetermination).WithMany(p => p.Pmrresults)
                .HasForeignKey(d => d.RangingDeterminationId)
                .HasConstraintName("FK_dbo.PMRResult_dbo.RangingDetermination_RangingDeterminationId");
        });

        modelBuilder.Entity<PmrsurveyBase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.PMRSurveyBase");

            entity.ToTable("PMRSurveyBase");

            entity.HasIndex(e => e.RangingDeterminationId, "IX_RangingDeterminationId");

            entity.HasIndex(e => e.RangingDeterminationId1, "IX_RangingDeterminationId1");

            entity.HasIndex(e => e.RangingDeterminationId2, "IX_RangingDeterminationId2");

            entity.HasIndex(e => e.RawSurveyId, "IX_RawSurveyId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Discriminator).HasMaxLength(128);

            entity.HasOne(d => d.RangingDetermination).WithMany(p => p.PmrsurveyBaseRangingDeterminations)
                .HasForeignKey(d => d.RangingDeterminationId)
                .HasConstraintName("FK_dbo.PMRSurveyBase_dbo.RangingDetermination_RangingDeterminationId");

            entity.HasOne(d => d.RangingDeterminationId1Navigation).WithMany(p => p.PmrsurveyBaseRangingDeterminationId1Navigations)
                .HasForeignKey(d => d.RangingDeterminationId1)
                .HasConstraintName("FK_dbo.PMRSurveyBase_dbo.RangingDetermination_RangingDeterminationId1");

            entity.HasOne(d => d.RangingDeterminationId2Navigation).WithMany(p => p.PmrsurveyBaseRangingDeterminationId2Navigations)
                .HasForeignKey(d => d.RangingDeterminationId2)
                .HasConstraintName("FK_dbo.PMRSurveyBase_dbo.RangingDetermination_RangingDeterminationId2");

            entity.HasOne(d => d.RawSurvey).WithMany(p => p.PmrsurveyBases)
                .HasForeignKey(d => d.RawSurveyId)
                .HasConstraintName("FK_dbo.PMRSurveyBase_dbo.RawSurvey_RawSurveyId");
        });

        modelBuilder.Entity<RangingDetermination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RangingDetermination");

            entity.ToTable("RangingDetermination");

            entity.HasIndex(e => e.WellId, "IX_WellId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.MaxBeg).HasColumnName("MaxBEg");
            entity.Property(e => e.MaxBeh).HasColumnName("MaxBEh");
            entity.Property(e => e.MaxRq).HasColumnName("MaxRQ");
            entity.Property(e => e.MinBeg).HasColumnName("MinBEg");
            entity.Property(e => e.MinBeh).HasColumnName("MinBEh");
            entity.Property(e => e.MinRq).HasColumnName("MinRQ");
            entity.Property(e => e.RunDpa).HasColumnName("RunDPA");
            entity.Property(e => e.RunHs2tg).HasColumnName("RunHS2TG");
            entity.Property(e => e.RunSpa).HasColumnName("RunSPA");

            entity.HasOne(d => d.Well).WithMany(p => p.RangingDeterminations)
                .HasForeignKey(d => d.WellId)
                .HasConstraintName("FK_dbo.RangingDetermination_dbo.Well_WellId");
        });

        modelBuilder.Entity<RawSurvey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RawSurvey");

            entity.ToTable("RawSurvey");

            entity.HasIndex(e => e.RunId, "IX_RunId");

            entity.HasIndex(e => e.SolutionId, "IX_SolutionId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Btotal).HasColumnName("BTotal");
            entity.Property(e => e.BtotalQcDelta).HasColumnName("BTotalQcDelta");
            entity.Property(e => e.Gtotal).HasColumnName("GTotal");
            entity.Property(e => e.GtotalQcDelta).HasColumnName("GTotalQcDelta");
            entity.Property(e => e.Mwdinclination).HasColumnName("MWDInclination");
            entity.Property(e => e.MwdlongCollar).HasColumnName("MWDLongCollar");
            entity.Property(e => e.MwdshortCollar).HasColumnName("MWDShortCollar");
            entity.Property(e => e.SolutionId).HasDefaultValueSql("('00000000-0000-0000-0000-000000000000')");

            entity.HasOne(d => d.Run).WithMany(p => p.RawSurveys)
                .HasForeignKey(d => d.RunId)
                .HasConstraintName("FK_dbo.RawSurvey_dbo.Run_RunId");
        });

        modelBuilder.Entity<ResourceGroup>(entity =>
        {
            entity.ToTable("ResourceGroup", "Security");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.LastEditedBy).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<Run>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Run");

            entity.ToTable("Run");

            entity.HasIndex(e => e.WellId, "IX_WellId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.AzimuthLongCollarTolerance).HasDefaultValueSql("((0.01))");
            entity.Property(e => e.EndTime).HasDefaultValueSql("('1970-01-01')");
            entity.Property(e => e.InclinationTolerance).HasDefaultValueSql("((0.01))");

            entity.HasOne(d => d.Well).WithMany(p => p.Runs)
                .HasForeignKey(d => d.WellId)
                .HasConstraintName("FK_dbo.Run_dbo.Well_WellId");
        });

        modelBuilder.Entity<Schema>(entity =>
        {
            entity.HasKey(e => e.SchemaVersion).HasName("PK__Schema__04D490DB874B1C71");

            entity.ToTable("Schema", "SignalR");

            entity.Property(e => e.SchemaVersion).ValueGeneratedNever();
        });

        modelBuilder.Entity<Shortsurvey>(entity =>
        {
            entity.ToTable("Shortsurvey");

            entity.Property(e => e.Id)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("ID");
            entity.Property(e => e.AzimuthType).HasDefaultValueSql("((2))");
            entity.Property(e => e.Btotal).HasColumnName("BTotal");
            entity.Property(e => e.CorrHa).HasColumnName("CorrHA");
            entity.Property(e => e.CorrHl).HasColumnName("CorrHL");
            entity.Property(e => e.CorrLa).HasColumnName("CorrLA");
            entity.Property(e => e.CourseLength).HasDefaultValueSql("((0.00))");
            entity.Property(e => e.CovEe).HasColumnName("CovEE");
            entity.Property(e => e.CovEv).HasColumnName("CovEV");
            entity.Property(e => e.CovNe).HasColumnName("CovNE");
            entity.Property(e => e.CovNn).HasColumnName("CovNN");
            entity.Property(e => e.CovNv).HasColumnName("CovNV");
            entity.Property(e => e.CovVv).HasColumnName("CovVV");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CreatedTime).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Gtotal).HasColumnName("GTotal");
            entity.Property(e => e.HmajSa).HasColumnName("HMajSA");
            entity.Property(e => e.HminSa).HasColumnName("HMinSA");
            entity.Property(e => e.LastEditedBy)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ToolCode).HasMaxLength(500);
            entity.Property(e => e.Tvd).HasColumnName("TVD");
            entity.Property(e => e.Tvdss).HasColumnName("TVDss");

            entity.HasOne(d => d.Run).WithMany(p => p.Shortsurveys)
                .HasForeignKey(d => d.RunId)
                .HasConstraintName("FK_Shortsurvey_Run");
        });

        modelBuilder.Entity<Solution>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Solution");

            entity.ToTable("Solution");

            entity.HasIndex(e => e.ObservatoryStationId, "IX_ObservatoryStationId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ApplyBgmisalignment).HasColumnName("ApplyBGMisalignment");
            entity.Property(e => e.AziType).HasDefaultValueSql("((0))");
            entity.Property(e => e.Bgmisalignment).HasColumnName("BGMisalignment");
            entity.Property(e => e.Dbe).HasColumnName("DBe");
            entity.Property(e => e.Dbh).HasColumnName("DBH");
            entity.Property(e => e.Dbnoise).HasColumnName("DBNoise");
            entity.Property(e => e.Dbx).HasColumnName("DBx");
            entity.Property(e => e.Dbxyz).HasColumnName("DBxyz");
            entity.Property(e => e.Dby).HasColumnName("DBy");
            entity.Property(e => e.Dbz).HasColumnName("DBz");
            entity.Property(e => e.DbzMod).HasColumnName("DBzMod");
            entity.Property(e => e.DdipNoise).HasColumnName("DDipNoise");
            entity.Property(e => e.Ddipe).HasColumnName("DDipe");
            entity.Property(e => e.Dec).HasColumnName("DEC");
            entity.Property(e => e.Dgxyz).HasColumnName("DGxyz");
            entity.Property(e => e.Diyquadrant).HasColumnName("DIYQuadrant");
            entity.Property(e => e.IcarusDgx).HasColumnName("IcarusDGx");
            entity.Property(e => e.IcarusDgy).HasColumnName("IcarusDGy");
            entity.Property(e => e.IcarusDgz).HasColumnName("IcarusDGz");
            entity.Property(e => e.IcarusSfgx).HasColumnName("IcarusSFGx");
            entity.Property(e => e.IcarusSfgy).HasColumnName("IcarusSFGy");
            entity.Property(e => e.Ifrdata).HasColumnName("IFRData");
            entity.Property(e => e.IpmtoolCode)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IPMToolCode");
            entity.Property(e => e.IsAdvancedMode).HasDefaultValueSql("((0))");
            entity.Property(e => e.MagneticReference).HasDefaultValueSql("((0))");
            entity.Property(e => e.Mode).HasDefaultValueSql("((0))");
            entity.Property(e => e.Msa)
                .HasDefaultValueSql("((0))")
                .HasColumnName("MSA");
            entity.Property(e => e.ObsSiteBtotal).HasColumnName("ObsSiteBTotal");
            entity.Property(e => e.Qctype)
                .HasDefaultValueSql("((0))")
                .HasColumnName("QCType");
            entity.Property(e => e.RunDynamicQc).HasColumnName("RunDynamicQC");
            entity.Property(e => e.Sfbx).HasColumnName("SFBx");
            entity.Property(e => e.Sfby).HasColumnName("SFBy");
            entity.Property(e => e.Sfequadrant).HasColumnName("SFEQuadrant");
            entity.Property(e => e.Sigma).HasDefaultValueSql("((2))");
            entity.Property(e => e.Tfcquadrant).HasColumnName("TFCQuadrant");
            entity.Property(e => e.TransXyquadrant).HasColumnName("TransXYQuadrant");

            entity.HasOne(d => d.ObservatoryStation).WithMany(p => p.Solutions)
                .HasForeignKey(d => d.ObservatoryStationId)
                .HasConstraintName("FK_dbo.Solution_dbo.ObservatoryStation_ObservatoryStationId");

            entity.HasOne(d => d.Run).WithMany(p => p.Solutions)
                .HasForeignKey(d => d.RunId)
                .HasConstraintName("FK_dbo.Solution_dbo.Run_RunId");
        });

        modelBuilder.Entity<SpatrialLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.SPATrialLog");

            entity.ToTable("SPATrialLog");

            entity.HasIndex(e => e.RangingDeterminationId, "IX_RangingDeterminationId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Beg).HasColumnName("BEg");
            entity.Property(e => e.Beh).HasColumnName("BEh");
            entity.Property(e => e.Rq).HasColumnName("RQ");

            entity.HasOne(d => d.RangingDetermination).WithMany(p => p.SpatrialLogs)
                .HasForeignKey(d => d.RangingDeterminationId)
                .HasConstraintName("FK_dbo.SPATrialLog_dbo.RangingDetermination_RangingDeterminationId");
        });

        modelBuilder.Entity<Template>(entity =>
        {
            entity.ToTable("Template");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(500);
            entity.Property(e => e.LastEditedBy).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<TraceLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.TraceLog");

            entity.ToTable("TraceLog");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<Uncertainty>(entity =>
        {
            entity.ToTable("Uncertainty");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CorrHa).HasColumnName("CorrHA");
            entity.Property(e => e.CorrHl).HasColumnName("CorrHL");
            entity.Property(e => e.CorrLa).HasColumnName("CorrLA");
            entity.Property(e => e.CovEe).HasColumnName("CovEE");
            entity.Property(e => e.CovEv).HasColumnName("CovEV");
            entity.Property(e => e.CovNe).HasColumnName("CovNE");
            entity.Property(e => e.CovNn).HasColumnName("CovNN");
            entity.Property(e => e.CovNv).HasColumnName("CovNV");
            entity.Property(e => e.CovVv).HasColumnName("CovVV");
            entity.Property(e => e.HmajSa).HasColumnName("HMajSA");
            entity.Property(e => e.HminSa).HasColumnName("HMinSA");
            entity.Property(e => e.ToolCode).HasMaxLength(500);

            entity.HasOne(d => d.CorrectedSurvey).WithMany(p => p.Uncertainties)
                .HasForeignKey(d => d.CorrectedSurveyId)
                .HasConstraintName("FK_dbo.Uncertainty_dbo.CorrectedSurvey_Id");
        });

        modelBuilder.Entity<WaitObservatoryCorrectedSurvey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.WaitObservatoryCorrectedSurvey");

            entity.ToTable("WaitObservatoryCorrectedSurvey");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
        });

        modelBuilder.Entity<Waypoint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Waypoint");

            entity.ToTable("Waypoint");

            entity.HasIndex(e => e.WellId, "IX_WellId");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Bggmbtotal).HasColumnName("BGGMBTotal");
            entity.Property(e => e.Bggmdeclination).HasColumnName("BGGMDeclination");
            entity.Property(e => e.Bggmdip).HasColumnName("BGGMDip");
            entity.Property(e => e.BggmtotalCorrection).HasColumnName("BGGMTotalCorrection");
            entity.Property(e => e.CabtOffset).HasColumnName("CABtOffset");
            entity.Property(e => e.CadecOffset).HasColumnName("CADecOffset");
            entity.Property(e => e.CadipOffset).HasColumnName("CADipOffset");
            entity.Property(e => e.Ifr1waypointMode)
                .HasDefaultValueSql("((1))")
                .HasColumnName("IFR1WaypointMode");
            entity.Property(e => e.Ifrbtotal).HasColumnName("IFRBTotal");
            entity.Property(e => e.Ifrdeclination).HasColumnName("IFRDeclination");
            entity.Property(e => e.Ifrdip).HasColumnName("IFRDip");
            entity.Property(e => e.IfrtotalCorrection).HasColumnName("IFRTotalCorrection");
            entity.Property(e => e.RefBtotal).HasColumnName("RefBTotal");
            entity.Property(e => e.WaypointMode).HasDefaultValueSql("((1))");

            entity.HasOne(d => d.Well).WithMany(p => p.Waypoints)
                .HasForeignKey(d => d.WellId)
                .HasConstraintName("FK_dbo.Waypoint_dbo.Well_WellId");
        });

        modelBuilder.Entity<Well>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.Well");

            entity.ToTable("Well");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Apinumber).HasColumnName("APINumber");
            entity.Property(e => e.Asamode).HasColumnName("ASAMode");
            entity.Property(e => e.AsapendingSessionCount).HasColumnName("ASAPendingSessionCount");
            entity.Property(e => e.AsasessionCount)
                .HasDefaultValueSql("((1))")
                .HasColumnName("ASASessionCount");
            entity.Property(e => e.AsastatusEnum)
                .HasDefaultValueSql("((7))")
                .HasColumnName("ASAStatusEnum");
            entity.Property(e => e.AutoCalcPosition)
                .IsRequired()
                .HasDefaultValueSql("((1))");
            entity.Property(e => e.Btotal).HasColumnName("BTotal");
            entity.Property(e => e.Ewdeparture).HasColumnName("EWDeparture");
            entity.Property(e => e.Gtotal)
                .HasDefaultValueSql("((1.0))")
                .HasColumnName("GTotal");
            entity.Property(e => e.ImportAdiserver).HasColumnName("ImportADIServer");
            entity.Property(e => e.IsForceUpdateHypercubeBgs).HasColumnName("IsForceUpdateHypercubeBGS");
            entity.Property(e => e.Nsdeparture).HasColumnName("NSDeparture");
            entity.Property(e => e.RigType).HasDefaultValueSql("((1))");
            entity.Property(e => e.Roc).HasColumnName("ROC");
            entity.Property(e => e.SigmaValue).HasDefaultValueSql("((1.0))");
            entity.Property(e => e.Tvd).HasColumnName("TVD");
            entity.Property(e => e.Uom).HasColumnName("UOM");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
