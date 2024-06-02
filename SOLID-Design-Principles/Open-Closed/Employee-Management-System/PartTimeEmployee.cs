public class PartTimeEmployee : IEmployees
{
    public double HourlyRate { get; set; }
    public double HoursWorked { get; set; }

    public double CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}
