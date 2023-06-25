using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class MaxSurveyRuleSetResponse
{
    public Guid Id { get; set; }

    public Guid CorrectedSurveyId { get; set; }

    public string? Message { get; set; }

    public int? Result { get; set; }

    public bool Deleted { get; set; }
}
