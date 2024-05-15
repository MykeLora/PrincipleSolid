public class ServiceCenter
{
    private readonly IVehicleService vehicleService;

    public ServiceCenter(IVehicleService vehicleService)
    {
        this.vehicleService = vehicleService;
    }

    public void ServiceVehicle(string model)
    {
        this.vehicleService.Service(model);
    }
}