public class NotificationSender
{
    private readonly INotificationChannel channel;

    public NotificationSender(INotificationChannel channel)
    {
        this.channel = channel;
    }

    public void SendNotification(string message)
    {
        this.channel.Send(message);
    }
}