using System;
internal class Program
{
    public static void Main(string[] args)
    {
        Vehicles vehicle = new GasolineVehicle();
        vehicle.StartEngine();

        vehicle  = new ElectrictVehicle();
        vehicle.StartEngine();


        Console.ReadKey();
    }

}