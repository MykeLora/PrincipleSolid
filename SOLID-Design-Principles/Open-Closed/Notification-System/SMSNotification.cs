public class SMSNotification : INotificationChannel
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending SMS: {message}");
    }
}
