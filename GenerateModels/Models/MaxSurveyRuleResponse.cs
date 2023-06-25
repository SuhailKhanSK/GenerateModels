using System;
using System.Collections.Generic;

namespace GenerateModels.Models;

public partial class MaxSurveyRuleResponse
{
    public Guid Id { get; set; }

    public Guid MaxSurveyRuleSetResponseId { get; set; }

    public string RuleName { get; set; } = null!;

    public string? RuleExpression { get; set; }

    public string? EvaluatedRuleExpression { get; set; }

    public int? Result { get; set; }

    public string Unit { get; set; } = null!;

    public string? Message { get; set; }

    public bool Deleted { get; set; }

    public string? PreConditionExpression { get; set; }

    public string? EvaluatedPreConditionExpression { get; set; }

    public string? PreConditionUnit { get; set; }

    public bool? PreConditionResult { get; set; }
}
