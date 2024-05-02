internal class Program
{
   
    private static void Main(string[] args)
    {
       Vehicle myCar = new Vehicle { VIN = "XYZ123", Model = "Model S", LastServiceDate = DateTime.Now.AddMonths(-13) };
       MaintenanceLog maintenance = new MaintenanceLog(myCar);
       
       maintenance.LogMaintenance("Replaced brake pads.");
       ServiceAlertHandler alertHandler = new ServiceAlertHandler(myCar);

        if (alertHandler.IsServiceDue())
        {
            alertHandler.SendServiceAlert();
        }
              
        Console.ReadKey();
    }
} 