public class TruckService : IVehicleService
{
    public void Service(string model)
    {
        Console.WriteLine($"Servicing Motorcycle. Model: {model}");
    }
}
