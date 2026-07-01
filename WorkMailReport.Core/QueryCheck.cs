namespace WorkMailReport.Core;

public sealed class QueryCheck
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public bool IsEnabled { get; set; } = true;
}
