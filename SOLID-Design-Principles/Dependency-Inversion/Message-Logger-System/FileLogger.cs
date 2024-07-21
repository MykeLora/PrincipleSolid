public class FileLoger : ILoger
{
    private string _filePath;
    public FileLoger(string filePath)
    {
        _filePath = filePath;
    }

    public void LogMessage(string message)
    {
        File.AppendAllText(_filePath, message);
    }
}