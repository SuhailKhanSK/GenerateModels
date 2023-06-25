using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class PmrsurveyBase
{
    public Guid Id { get; set; }

    public bool Deleted { get; set; }

    public Guid RawSurveyId { get; set; }

    public Guid? RangingDeterminationId { get; set; }

    public Guid? RangingDeterminationId1 { get; set; }

    public Guid? RangingDeterminationId2 { get; set; }

    public string Discriminator { get; set; } = null!;

    public virtual RangingDetermination? RangingDetermination { get; set; }

    public virtual RangingDetermination? RangingDeterminationId1Navigation { get; set; }

    public virtual RangingDetermination? RangingDeterminationId2Navigation { get; set; }

    public virtual RawSurvey RawSurvey { get; set; } = null!;
}
