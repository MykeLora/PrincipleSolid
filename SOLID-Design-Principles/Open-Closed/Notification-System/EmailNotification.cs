public class EmailNotification : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email: {message}");
    }
}