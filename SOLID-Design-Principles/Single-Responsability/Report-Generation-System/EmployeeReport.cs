public class EmployeeReport
{
    private readonly Employee employee;

    public EmployeeReport(Employee employee)
    {
        this.employee = employee;
    }

    public string GenerateReportContent()
    {
        return $"Employee: {employee.Name}, Hours: {employee.HoursWorked}, Pay: {employee.Pay}";
    }


}