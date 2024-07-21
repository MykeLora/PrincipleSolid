
public class ConsoleLogger : ILoger
{
    public void LogMessage(string message)
    {
        Console.WriteLine(message);
    }
}
