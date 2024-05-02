public class ServiceAlertHandler
{
    private readonly Vehicle vehicle;

    public ServiceAlertHandler(Vehicle vehicle)
    {
        this.vehicle = vehicle;
    }

    public bool IsServiceDue()
    {
        return (DateTime.Now - this.vehicle.LastServiceDate).TotalDays > 365;
    }

    public void SendServiceAlert()
    {
        if(IsServiceDue())
        {
            Console.WriteLine("Service Alert Send to Customer");
        }
    }
}