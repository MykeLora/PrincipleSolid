public class Intern : IEmployees
{
    public double HourlyRate { get; set;}
    public double HoursWorked { get; set;}
    public double CalculateSalary()
    {
        return HourlyRate * HoursWorked * 0.5;
    }
}
