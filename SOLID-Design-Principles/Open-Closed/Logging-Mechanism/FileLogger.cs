public class FileLogger : IRecorder
{

    public void LogMessage(string message)
    {
        Console.WriteLine($"Logged to file: {message}");
    }
}
