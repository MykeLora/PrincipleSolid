public class DatabaseLogger : IRecorder
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"Logged to database: {message}");
    }
}
