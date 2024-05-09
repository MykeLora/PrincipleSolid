using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var filelogger = new FileLogger();
        var logger = new Recorder(filelogger);
        logger.LogMesage("This is a file log.");

        var dbLogger = new DatabaseLogger();
        logger = new Recorder(dbLogger);
        logger.LogMesage("This is a database log.");

        var cloudLogger = new CloudStoredLogger();
        logger = new Recorder(cloudLogger);
        logger.LogMesage("This is a cloud log.");


        Console.ReadKey();
    }
}