public class MaintenanceLog
{
    private readonly Vehicle vehicle;

    public MaintenanceLog(Vehicle vehicle)
    {
        this.vehicle = vehicle;
    }

    public void LogMaintenance(string details)
    {
        Console.WriteLine(details);
    }
}