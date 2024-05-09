using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var emaiChannel = new EmailNotification();
        var sender = new NotificationSender(emaiChannel);
        sender.SendNotification("Hello by this via Email!");

        var smsChannel = new SMSNotification();
        sender = new NotificationSender(smsChannel);
        sender.SendNotification("Hello by this via SMS!");
        
        Console.ReadKey();
    }
}