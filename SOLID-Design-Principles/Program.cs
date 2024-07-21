using System;
public class Program
{

    public static void Main(string[] args)
    {
        var consoleLogger = new ConsoleLogger();
        var NotificationService1 = new NotificationService(consoleLogger);
        
        var fileLoger = new FileLoger("path_to_log_file.txt");
        var notificationService2 = new NotificationService(fileLoger);
        Console.ReadKey();
    }

}