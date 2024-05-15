using System;
internal class Program
{
    private static void Main(string[] args)
    {
        var carService = new CarService();
        var center = new ServiceCenter(carService);
        center.ServiceVehicle("Sedan");

        var truckService = new TruckService();
        center = new ServiceCenter(truckService);
        center.ServiceVehicle("18-Wheeler");
        
        Console.ReadKey();
    }
}