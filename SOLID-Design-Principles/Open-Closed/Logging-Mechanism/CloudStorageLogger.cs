public class CloudStoredLogger : IRecorder
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Logged to cloud Storage: {message}");
    }
}
