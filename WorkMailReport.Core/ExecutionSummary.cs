namespace WorkMailReport.Core;

public sealed class ExecutionSummary
{
    public DateTimeOffset StartedAt { get; set; } = DateTimeOffset.Now;
    public DateTimeOffset? FinishedAt { get; set; }
    public int TotalCount { get; set; }
    public int SuccessCount { get; set; }
    public int WarningCount { get; set; }
    public int ErrorCount { get; set; }
}
