public class FullTimeEmployee : IEmployees
{
    public double HourlyRate { get; set;}
    public double CalculateSalary()
    {
        return HourlyRate * 160;
    }
}
