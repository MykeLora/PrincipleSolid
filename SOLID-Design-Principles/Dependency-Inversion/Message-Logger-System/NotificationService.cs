public class NotificationService
{
    private  ILoger _loger;

    public NotificationService(ILoger loger)
    {
        _loger = loger;
    }

    public void Notify(string message)
    {
        _loger.LogMessage(message);
    }
}