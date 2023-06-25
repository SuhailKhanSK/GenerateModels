using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class WaitObservatoryCorrectedSurvey
{
    public Guid Id { get; set; }

    public Guid CorrectedSurveyId { get; set; }

    public Guid ObservatoryStationId { get; set; }

    public Guid WellId { get; set; }

    public DateTime ReserveTime { get; set; }

    public DateTime ObservatoryTime { get; set; }

    public bool Deleted { get; set; }
}
