namespace WorkMailReport.Core;

public sealed class TargetInfo
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsEnabled { get; set; } = true;
}
