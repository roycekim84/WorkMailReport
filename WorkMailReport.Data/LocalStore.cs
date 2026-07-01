namespace WorkMailReport.Data;

public sealed class LocalStore
{
    public string FilePath { get; }

    public LocalStore(string filePath)
    {
        FilePath = filePath;
    }
}
