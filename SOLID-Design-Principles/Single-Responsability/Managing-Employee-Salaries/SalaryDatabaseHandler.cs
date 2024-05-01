public class SalaryDatabaseHandler
{
    public void SaveSalaryDetails(EmployeeSalary salary, double totalSalary)
    {
        Console.WriteLine($"Employee {salary.EmployeeName} Salary {totalSalary} Saved to DB");
    }
}