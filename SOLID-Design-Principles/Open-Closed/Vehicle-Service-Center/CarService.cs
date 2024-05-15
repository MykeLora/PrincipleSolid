public class CarService : IVehicleService
{
    public void Service(string model)
    {
        Console.WriteLine($"Servicing Car. Model: {model}");
    }
}